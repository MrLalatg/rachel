using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDL2;
using Transitions;

namespace RacheM
{
    public partial class overlay : Form
    {
        private IntPtr sdlWindow;
        private IntPtr renderer;

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowPos(
            IntPtr handle,
            IntPtr handleAfter,
            int x,
            int y,
            int cx,
            int cy,
            uint flags
        );
        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr child, IntPtr newParent);
        [DllImport("user32.dll")]
        private static extern IntPtr ShowWindow(IntPtr handle, int command);

        Random rnd = new Random();
        public overlay()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) != 0)
            {
                MessageBox.Show(SDL.SDL_GetError());
            }

            if(SDL_ttf.TTF_Init() != 0)
            {
                //MessageBox.Show(SDL.SDL_GetError());
            }
            sdlWindow = SDL.SDL_CreateWindow(String.Empty, 0, 0, this.sdlPanel.Size.Width, this.sdlPanel.Size.Height, SDL.SDL_WindowFlags.SDL_WINDOW_BORDERLESS);

            SDL.SDL_SysWMinfo info = new SDL.SDL_SysWMinfo();
            SDL.SDL_GetWindowWMInfo(sdlWindow, ref info);
            IntPtr winHandle = info.info.win.window;

            SetWindowPos(
                winHandle,
                Handle,
                0,
                0,
                0,
                0,
                0x0401 // NOSIZE | SHOWWINDOW
            );

            renderer = SDL.SDL_CreateRenderer(sdlWindow, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED | SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);

            SetParent(winHandle, sdlPanel.Handle);
            ShowWindow(winHandle, 1); // SHOWNORMAL
        }

        public void ride(User curUsr, int prizeType = 0)
        {
            this.button1.Show();

            IntPtr font = SDL_ttf.TTF_OpenFont(Path.Combine(Directory.GetCurrentDirectory(), "unispace.ttf"), 48);

            IntPtr textSurface = SDL_ttf.TTF_RenderText_Solid(font, curUsr.Name, new SDL.SDL_Color { r = 255, g = 140, b = 0});


            int ImageCount = 60;
            int ImageLength = 170;

            int endPtr = 0;
            var randomPrizes = getRandomPrizes(ImageCount);
            string LongImage = buildSausage(randomPrizes, ImageLength, out endPtr);
            IntPtr bmp = SDL.SDL_LoadBMP(LongImage);
            IntPtr texture = SDL.SDL_CreateTextureFromSurface(renderer, bmp);
            IntPtr text = SDL.SDL_CreateTextureFromSurface(renderer, textSurface);

            int speed = 40;

            bool beginStop = false;

            SDL.SDL_Rect srcRect = new SDL.SDL_Rect { x = 0, y = 0, w = 1280, h = 170};
            SDL.SDL_Rect dstRect = new SDL.SDL_Rect { x = 0, y = 0, w = 1280, h = 170};
            SDL.SDL_Rect textRect = new SDL.SDL_Rect { x = 640 - (40 * curUsr.Name.Length/2), y = 176, w = 40 * curUsr.Name.Length, h = 77};

            int i = 0;
            for (i = 0; i < endPtr; i += speed)
            {
                SDL.SDL_RenderCopy(renderer, texture, ref srcRect, ref dstRect);
                SDL.SDL_RenderCopy(renderer, text, IntPtr.Zero, ref textRect);
                srcRect.x = i;
                SDL.SDL_RenderPresent(renderer);

                speed = (int)((Math.Cos((i * Math.PI) / (ImageLength * ImageCount)) + 1) * 15);
                if (speed == 1 && !beginStop)
                {
                    beginStop = true;
                    int randomEnd = rnd.Next(10, 160);
                    if (i + randomEnd + 1280 > endPtr)
                    {
                        endPtr = i + ((i + randomEnd) - endPtr);
                    }
                    else
                    {
                        endPtr = i + randomEnd;
                    }
                }
            }

            System.Threading.Thread.Sleep(3000);

            SDL.SDL_RenderClear(renderer);
            SDL.SDL_RenderPresent(renderer);

            

            curUsr.prizes.Add(randomPrizes[(i + 1280 / 2) / 170]);
            db.saveUser(curUsr);
            this.button1.Hide();
        }

        private List<PrizeItem> getRandomPrizes(int count)
        {
            //List<PrizeItem> allPrizes = db.getPrizes().Where(p => p.Value.Type != 2).Select(p => p.Value).ToList();
            List<PrizeItem> allPrizes = db.getPrizes().Select(p => p.Value).ToList();
            List<PrizeItem> result = new List<PrizeItem>();
            List<PrizeItem> tempres = new List<PrizeItem>();
            int r1 = (int)((count / 100M) * 60);
            int r2 = (int)((count / 100M) * 30);
            int r3 = (int)((count / 100M) * 8);

            for (int i = 0; i < r1; i++)
            {
                tempres = allPrizes.Where(p => p.IsBad == 3).ToList();
                result.Add(tempres[rnd.Next(0, tempres.Count)]);
            }

            for (int i = 0; i < r2; i++)
            {
                tempres = allPrizes.Where(p => p.IsBad == 2).ToList();
                result.Add(tempres[rnd.Next(0, tempres.Count)]);
            }

            for (int i = 0; i < r3; i++)
            {
                tempres = allPrizes.Where(p => p.IsBad == 1).ToList();
                result.Add(tempres[rnd.Next(0, tempres.Count)]);
            }

            if (rnd.Next(1, 1001) == 7)
            {
                result[rnd.Next(0, result.Count)] = db.getPrizes().Where(p => p.Value.Type == -1).Select(p => p.Value).FirstOrDefault();
            }


            return result.Select(r => new { item = r, ord = rnd.Next() }).OrderBy(r => r.ord).Select(r => r.item).ToList();
        }

        private string buildSausage(List<PrizeItem> prizes, int imageLength, out int outLength)
        {
            Bitmap sausage = new Bitmap(170 * prizes.Count, imageLength);
            outLength = sausage.Size.Width;
            Graphics g = Graphics.FromImage(sausage);
            for (int i = 0; i < prizes.Count; i++)
            {
                g.DrawImage(prizes[i].Image, new Rectangle(imageLength * i, 0, imageLength, imageLength));
            }
            var fileName = Path.Combine(Directory.GetCurrentDirectory(), "rollImg");
            sausage.Save(fileName, ImageFormat.Bmp);

            return fileName;
        }

        public void paintGreen()
        {
            SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
            SDL.SDL_RenderClear(renderer);
            SDL.SDL_RenderPresent(renderer);
        }
    }
}

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

        private Dictionary<int, Color> rarityColors = new Dictionary<int, Color>()
        {
            {-1, Color.FromArgb(218, 165, 32)},
            {1, Color.FromArgb(160, 0, 0)},
            {2, Color.FromArgb(108, 13, 163)},
            {3, Color.FromArgb(42, 18, 181)}
        };

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
                MessageBox.Show(SDL.SDL_GetError());
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

            SDL.SDL_SetRenderDrawBlendMode(renderer, SDL.SDL_BlendMode.SDL_BLENDMODE_BLEND);

            SetParent(winHandle, sdlPanel.Handle);
            ShowWindow(winHandle, 1); // SHOWNORMAL
        }

        public void fastRide(User curUsr, float price)
        {
            IntPtr font = SDL_ttf.TTF_OpenFont(Path.Combine(Directory.GetCurrentDirectory(), "unispace.ttf"), 48);

            IntPtr textSurface = SDL_ttf.TTF_RenderUNICODE_Blended(font, curUsr.Name, new SDL.SDL_Color { r = 255, g = 255, b = 255 });
            SDL.SDL_Rect textRect = new SDL.SDL_Rect { x = 1280 - (40 * curUsr.Name.Length), y = 0, w = 40 * curUsr.Name.Length, h = 77 };

            int ImageCount = 60;
            int ImageLength = 170;

            List<PrizeItem> displayPrizes = new List<PrizeItem>();
            Dictionary<string, int> renderedPrizes = new Dictionary<string, int>();
            IntPtr text = SDL.SDL_CreateTextureFromSurface(renderer, textSurface);

            for (int j = 0; j < (int)price / 100; j++)
            {
                int endPtr = 0;
                var randomPrizes = getRandomPrizes(ImageCount);
                IntPtr LongImage = buildSausage(randomPrizes, ImageLength, out endPtr);

                if (j == 0)
                {
                    textRect.x += 1280;

                    int animationSpeed = 32;

                    for (int k = 1280; k >= 0; k -= animationSpeed)
                    {
                        SDL.SDL_RenderClear(renderer);
                        textRect.x -= animationSpeed;
                        SDL.SDL_Rect marginRect = textRect;
                        marginRect.x -= 10;
                        marginRect.w += 20;
                        SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
                        SDL.SDL_RenderFillRect(renderer, ref marginRect);
                        SDL.SDL_RenderCopy(renderer, text, IntPtr.Zero, ref textRect);
                        SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                        SDL.SDL_RenderPresent(renderer);
                    }
                }
                else
                {
                    SDL.SDL_Rect marginRect = textRect;
                    marginRect.x -= 10;
                    marginRect.w += 20;
                    SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
                    SDL.SDL_RenderFillRect(renderer, ref marginRect);
                    SDL.SDL_RenderCopy(renderer, text, IntPtr.Zero, ref textRect);
                    SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                    SDL.SDL_RenderPresent(renderer);
                }

                int randomPixel = rnd.Next(1, endPtr);

                PrizeItem resultPrize = randomPrizes[randomPixel / 170];

                db.addPrizeToPlayer(curUsr, resultPrize);
                displayPrizes.Add(resultPrize);
                mainForm.logger.AddEntry(curUsr, resultPrize);

                var groupedPrizes = displayPrizes.GroupBy(prize => prize.Name).ToList();
                for (int groupI = 0; groupI < groupedPrizes.Count; groupI++)
                {
                    bool xflag = false;
                    Color curColor = rarityColors[groupedPrizes[groupI].First().IsBad];
                    IntPtr prizeFont = SDL_ttf.TTF_OpenFont(Path.Combine(Directory.GetCurrentDirectory(), "unispace.ttf"), 50);
                    IntPtr prizeSurface = SDL_ttf.TTF_RenderUNICODE_Blended(prizeFont, $"{groupedPrizes[groupI].Key} x{groupedPrizes[groupI].Count()}", new SDL.SDL_Color { r = 255, g = 255, b = 255 });
                    SDL.SDL_Rect prizeTextRect = new SDL.SDL_Rect { x = 1280, y = 83 + groupI * 50, w = ((SDL.SDL_Surface)Marshal.PtrToStructure(prizeSurface, typeof(SDL.SDL_Surface))).w, h = 50 };
                    IntPtr prizeText = SDL.SDL_CreateTextureFromSurface(renderer, prizeSurface);

                    int margin = 10;

                    if (renderedPrizes.Keys.Contains(groupedPrizes[groupI].Key))
                    {
                        if (renderedPrizes[groupedPrizes[groupI].Key] != groupedPrizes[groupI].Count())
                        {
                            xflag = true;
                        }
                        else
                        {
                            prizeTextRect.x -= prizeTextRect.w + margin;
                            SDL.SDL_Rect marginRect = prizeTextRect;
                            marginRect.x -= margin;
                            marginRect.w += margin * 2;
                            SDL.SDL_SetRenderDrawColor(renderer, curColor.R, curColor.G, curColor.B, 255);
                            SDL.SDL_RenderFillRect(renderer, ref marginRect);
                            SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                            SDL.SDL_RenderCopy(renderer, prizeText, IntPtr.Zero, ref prizeTextRect);
                            SDL.SDL_RenderPresent(renderer);
                            continue;
                        }
                    }
                    int overflow = prizeTextRect.w + margin;
                    while (true)
                    {
                        prizeTextRect.x -= 10;
                        if (prizeTextRect.x < 1280 - overflow)
                        {
                            prizeTextRect.x = 1280 - overflow;
                        }
                        SDL.SDL_Rect marginRect = prizeTextRect;
                        marginRect.x -= margin;
                        marginRect.w += margin * 2;
                        SDL.SDL_SetRenderDrawColor(renderer, curColor.R, curColor.G, curColor.B, 255);
                        SDL.SDL_RenderFillRect(renderer, ref marginRect);
                        SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                        SDL.SDL_RenderCopy(renderer, prizeText, IntPtr.Zero, ref prizeTextRect);
                        SDL.SDL_RenderPresent(renderer);
                        if (prizeTextRect.x == 1280 - overflow)
                        {
                            break;
                        }
                    }
                    if (xflag)
                    {
                        renderedPrizes[groupedPrizes[groupI].Key] += 1;
                    }
                    else
                    {
                        renderedPrizes.Add(groupedPrizes[groupI].Key, 1);
                    }

                }
            }

            System.Threading.Thread.Sleep(3000);

            for (int z = 0; z < 1281 / 32; z++)
            {
                textRect.x += 32;
                SDL.SDL_RenderClear(renderer);
                SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
                SDL.SDL_RenderDrawRect(renderer, ref textRect);
                SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                SDL.SDL_RenderCopy(renderer, text, IntPtr.Zero, ref textRect);
                SDL.SDL_RenderPresent(renderer);
            }

            db.addPlayerBalance(curUsr.Name, -((int)price / 100) * 100);

            SDL.SDL_RenderClear(renderer);
            SDL.SDL_RenderPresent(renderer);
        }

        public void ride(User curUsr, float price, int prizeType = 0)
        {
            this.button1.Show();

            IntPtr font = SDL_ttf.TTF_OpenFont(Path.Combine(Directory.GetCurrentDirectory(), "unispace.ttf"), 48);

            IntPtr textSurface = SDL_ttf.TTF_RenderUNICODE_Blended(font, curUsr.Name, new SDL.SDL_Color { r = 255, g = 255, b = 255});
            SDL.SDL_Rect textRect = new SDL.SDL_Rect { x = 1280 - (40 * curUsr.Name.Length), y = 0, w = 40 * curUsr.Name.Length, h = 77 };

            int ImageCount = 60;
            int ImageLength = 170;

            List<PrizeItem> displayPrizes = new List<PrizeItem>();
            Dictionary<string, int> renderedPrizes = new Dictionary<string, int>();

            int endPtr = 0;
            List<PrizeItem> randomPrizes;
            //string LongImage = buildSausage(randomPrizes, ImageLength, out endPtr);
            IntPtr bmp;
            IntPtr texture = IntPtr.Zero;
            IntPtr text = SDL.SDL_CreateTextureFromSurface(renderer, textSurface);

            SDL.SDL_Rect srcRect = new SDL.SDL_Rect { x = 0, y = 0, w = 1280, h = 170 };
            SDL.SDL_Rect dstRect = new SDL.SDL_Rect { x = 0, y = 83, w = 1280, h = 170 };

            double delta_time = 0;

            for (int j = 0; j < (int)price / 100; j++)
            {
                randomPrizes = getRandomPrizes(ImageCount);
                //LongImage = buildSausage(randomPrizes, ImageLength, out endPtr);
                bmp = buildSausage(randomPrizes, ImageLength, out endPtr);
                texture = SDL.SDL_CreateTextureFromSurface(renderer, bmp);
                
                if (j == 0)
                {
                    SDL.SDL_Rect animationRect = dstRect;

                    animationRect.x += 1280;
                    textRect.x += 1280;

                    int animationSpeed = 32;

                    for (int k = 1280; k >= 0; k -= animationSpeed)
                    {
                        SDL.SDL_RenderClear(renderer);
                        animationRect.x -= animationSpeed;
                        textRect.x -= animationSpeed;
                        SDL.SDL_Rect marginRect = textRect;
                        marginRect.x -= 10;
                        marginRect.w += 20;
                        SDL.SDL_RenderCopy(renderer, texture, ref srcRect, ref animationRect);
                        SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
                        SDL.SDL_RenderFillRect(renderer, ref marginRect);
                        SDL.SDL_RenderCopy(renderer, text, IntPtr.Zero, ref textRect);
                        SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                        SDL.SDL_RenderPresent(renderer);
                    }
                } else
                {
                    SDL.SDL_Rect marginRect = textRect;
                    marginRect.x -= 10;
                    marginRect.w += 20;
                    SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
                    SDL.SDL_RenderFillRect(renderer, ref marginRect);
                    SDL.SDL_RenderCopy(renderer, text, IntPtr.Zero, ref textRect);
                    SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                    SDL.SDL_RenderPresent(renderer);
                }

                double speed = rnd.Next(1000, 1501);
                double i = 0;

                DateTime lastTime = DateTime.Now;

                int debugMs = 0;
                int debugCount = 0;


                while(true)
                {
                    debugCount++;
                    DateTime currentTime = DateTime.Now;
                    delta_time = (currentTime - lastTime).TotalSeconds;
                    debugMs += (int)(delta_time * 1000);
                    i += speed * delta_time;

                    if (i > (ImageLength * ImageCount))
                    {
                        i -= (ImageLength * ImageCount);
                    }

                    srcRect.x = (int)Math.Round(i);

                    if (srcRect.x >= (ImageLength * ImageCount) - 1280)
                    {
                        int difference = -((ImageLength * ImageCount) - 1280 - srcRect.x);
                        SDL.SDL_Rect oldSrc = new SDL.SDL_Rect() { x = (int)Math.Round(i), y = 0, w = 1280 - difference, h = dstRect.h };
                        SDL.SDL_Rect newSrc = new SDL.SDL_Rect() { x = 0, y = 0, w = difference, h = dstRect.h };
                        SDL.SDL_Rect oldDst = new SDL.SDL_Rect() { x = 0, y = dstRect.y, w = oldSrc.w, h = dstRect.h };
                        SDL.SDL_Rect newDst = new SDL.SDL_Rect() { x = 1280 - difference, y = dstRect.y, w = newSrc.w, h = dstRect.h };
                        SDL.SDL_RenderCopy(renderer, texture, ref oldSrc, ref oldDst);
                        SDL.SDL_RenderCopy(renderer, texture, ref newSrc, ref newDst);
                    }
                    else
                    {
                        SDL.SDL_RenderCopy(renderer, texture, ref srcRect, ref dstRect);
                    }

                    SDL.SDL_RenderPresent(renderer);

                    speed -= 80 * delta_time;
                    if (speed < 0.5)
                    {
                        break;
                    }

                    int frameTime = (int)(DateTime.Now - currentTime).TotalMilliseconds;

                    if (mainForm.settings.fpsLimit > 0)
                    {
                        if (frameTime < (1000 / mainForm.settings.fpsLimit) - 5)
                        {
                            SDL.SDL_Delay((uint)((1000 / mainForm.settings.fpsLimit) - frameTime));
                        }
                    }

                    //if (debugCount % 100 == 0)
                    //{
                    //    SDL.SDL_Rect fpsRect = new SDL.SDL_Rect { x = 0, y = 0, h = 50, w = 50 };
                    //    IntPtr fps = SDL_ttf.TTF_RenderUNICODE_Blended(font, ((int)(1000/((double)debugMs / (double)debugCount))).ToString(), new SDL.SDL_Color { r = 255, g = 255, b = 255 });
                    //    IntPtr fpsTexture = SDL.SDL_CreateTextureFromSurface(renderer, fps);
                    //    SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                    //    SDL.SDL_RenderFillRect(renderer, ref fpsRect);
                    //    SDL.SDL_RenderCopy(renderer, fpsTexture, IntPtr.Zero, ref fpsRect);
                    //    SDL.SDL_RenderPresent(renderer);
                    //    debugCount = 0;
                    //    debugMs = 0;
                    //}
                    lastTime = currentTime;
                }

                System.Threading.Thread.Sleep(300);

                int lastI = ((int)Math.Round(i)+ 1280 / 2);

                if (lastI > ImageCount * ImageLength)
                {
                    lastI -= ImageCount * ImageLength;
                }

                int prizeResultX = (lastI / 170);

                PrizeItem resultPrize = randomPrizes[prizeResultX];

                db.addPrizeToPlayer(curUsr, resultPrize);
                displayPrizes.Add(resultPrize);
                mainForm.logger.AddEntry(curUsr, resultPrize);

                var groupedPrizes = displayPrizes.GroupBy(prize => prize.Name).ToList();
                for (int groupI = 0; groupI < groupedPrizes.Count; groupI++)
                {
                    bool xflag = false;
                    Color curColor = rarityColors[groupedPrizes[groupI].First().IsBad];
                    IntPtr prizeFont = SDL_ttf.TTF_OpenFont(Path.Combine(Directory.GetCurrentDirectory(), "unispace.ttf"), 50);
                    IntPtr prizeSurface = SDL_ttf.TTF_RenderUNICODE_Blended(prizeFont, $"{groupedPrizes[groupI].Key} x{groupedPrizes[groupI].Count()}", new SDL.SDL_Color { r = 255, g = 255, b = 255 });
                    SDL.SDL_Rect prizeTextRect = new SDL.SDL_Rect { x = 1280, y = 263 + groupI * 50, w = ((SDL.SDL_Surface)Marshal.PtrToStructure(prizeSurface, typeof(SDL.SDL_Surface))).w, h = 50 };
                    IntPtr prizeText = SDL.SDL_CreateTextureFromSurface(renderer, prizeSurface);

                    //SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                    //SDL.SDL_Rect clear = prizeTextRect;
                    //clear.x = 0;
                    //clear.w = 1280;
                    //SDL.SDL_RenderFillRect(renderer, ref clear);
                    //SDL.SDL_RenderPresent(renderer);

                    int margin = 10;

                    if (renderedPrizes.Keys.Contains(groupedPrizes[groupI].Key))
                    {
                        if (renderedPrizes[groupedPrizes[groupI].Key] != groupedPrizes[groupI].Count())
                        {
                            xflag = true;
                        } else
                        {
                            prizeTextRect.x -= prizeTextRect.w + margin;
                            SDL.SDL_Rect marginRect = prizeTextRect;
                            marginRect.x -= margin;
                            marginRect.w += margin*2;
                            SDL.SDL_SetRenderDrawColor(renderer, curColor.R, curColor.G, curColor.B, 255);
                            SDL.SDL_RenderFillRect(renderer, ref marginRect);
                            SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                            SDL.SDL_RenderCopy(renderer, prizeText, IntPtr.Zero, ref prizeTextRect);
                            SDL.SDL_RenderPresent(renderer);
                            continue;
                        }
                    }
                    int overflow = prizeTextRect.w + margin;
                    while (true)
                    {
                        prizeTextRect.x -= 10;
                        if(prizeTextRect.x < 1280 - overflow)
                        {
                            prizeTextRect.x = 1280 - overflow;
                        }
                        SDL.SDL_Rect marginRect = prizeTextRect;
                        marginRect.x -= margin;
                        marginRect.w += margin*2;
                        SDL.SDL_SetRenderDrawColor(renderer, curColor.R, curColor.G, curColor.B, 255);
                        SDL.SDL_RenderFillRect(renderer, ref marginRect);
                        SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                        SDL.SDL_RenderCopy(renderer, prizeText, IntPtr.Zero, ref prizeTextRect);
                        SDL.SDL_RenderPresent(renderer);
                        if (prizeTextRect.x == 1280 - overflow)
                        {
                            break;
                        }
                    }

                    if (xflag)
                    {
                        renderedPrizes[groupedPrizes[groupI].Key] += 1;
                    } else
                    {
                        renderedPrizes.Add(groupedPrizes[groupI].Key, 1);
                    }
                    
                }
            }

            System.Threading.Thread.Sleep(3000);

            int animationX = 0;

            while (animationX < 1280)
            {
                DateTime currentTime = DateTime.Now;

                SDL.SDL_RenderClear(renderer);
                animationX += (int) (1000 * delta_time);
                if (srcRect.x >= (ImageLength * ImageCount) - 1280)
                {
                    int difference = -((ImageLength * ImageCount) - 1280 - srcRect.x);
                    SDL.SDL_Rect oldSrc = new SDL.SDL_Rect() { x = srcRect.x, y = 0, w = 1280 - difference, h = dstRect.h };
                    SDL.SDL_Rect newSrc = new SDL.SDL_Rect() { x = 0, y = 0, w = difference, h = dstRect.h };
                    SDL.SDL_Rect oldDst = new SDL.SDL_Rect() { x = animationX, y = dstRect.y, w = oldSrc.w, h = dstRect.h };
                    SDL.SDL_Rect newDst = new SDL.SDL_Rect() { x = 1280 - difference + animationX, y = dstRect.y, w = newSrc.w, h = dstRect.h };
                    SDL.SDL_RenderCopy(renderer, texture, ref oldSrc, ref oldDst);
                    SDL.SDL_RenderCopy(renderer, texture, ref newSrc, ref newDst);
                }
                else
                {
                    dstRect.x = animationX;
                    SDL.SDL_RenderCopy(renderer, texture, ref srcRect, ref dstRect);
                }

                SDL.SDL_Rect animationTextRect = textRect;
                animationTextRect.x += animationX;
                SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
                SDL.SDL_RenderDrawRect(renderer, ref animationTextRect);
                SDL.SDL_RenderCopy(renderer, text, IntPtr.Zero, ref animationTextRect);
                SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                SDL.SDL_RenderPresent(renderer);

                int frameTime = (int)(DateTime.Now - currentTime).TotalMilliseconds;

                if (mainForm.settings.fpsLimit > 0)
                {
                    if (frameTime < (1000 / mainForm.settings.fpsLimit) - 5)
                    {
                        SDL.SDL_Delay((uint)((1000 / mainForm.settings.fpsLimit) - frameTime));
                    }
                }
            }

            db.addPlayerBalance(curUsr.Name, -((int)price / 100)*100);

            SDL.SDL_RenderClear(renderer);
            SDL.SDL_RenderPresent(renderer);

            this.button1.Hide();
        }

        private List<PrizeItem> getRandomPrizes(int count)
        {
            List<PrizeItem> allPrizes = db.getPrizes().Select(p => p.Value).ToList();
            List<PrizeItem> result = new List<PrizeItem>();
            List<PrizeItem> tempres = new List<PrizeItem>();
            int r1 = (int)((count / 100M) * 65);
            int r2 = (int)((count / 100M) * 30);
            int r3 = (int)((count / 100M) * 5);

            int delta = count - (r1 + r2 + r3);

            if (delta != 0)
            {
                r1 += delta;
            }

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

            if (rnd.Next(1, 101) == 7)
            {
                result[rnd.Next(0, result.Count)] = db.getPrizes().Where(p => p.Value.IsBad == 0).Select(p => p.Value).FirstOrDefault();
            }

            if (rnd.Next(1, 201) == 7)
            {
                result[rnd.Next(0, result.Count)] = db.getPrizes().Where(p => p.Value.Type == -1).Select(p => p.Value).FirstOrDefault();
            }

            return result.Select(r => new { item = r, ord = rnd.Next() }).OrderBy(r => r.ord).Select(r => r.item).ToList();
        }

        private IntPtr buildSausage(List<PrizeItem> prizes, int imageLength, out int outLength)
        {
            Bitmap sausage = new Bitmap(170 * prizes.Count, imageLength);
            outLength = sausage.Size.Width;
            Graphics g = Graphics.FromImage(sausage);
            for (int i = 0; i < prizes.Count; i++)
            {
                g.DrawImage(prizes[i].Image, new Rectangle(imageLength * i, 0, imageLength, imageLength));
            }

            BitmapData iconData = sausage.LockBits(new Rectangle(0, 0, sausage.Width, sausage.Height),
              System.Drawing.Imaging.ImageLockMode.ReadOnly,
              System.Drawing.Imaging.PixelFormat.Format32bppArgb); // lock data
            IntPtr iconSurface = SDL.SDL_CreateRGBSurfaceFrom(iconData.Scan0, sausage.Width, sausage.Height, 32, iconData.Stride,
              0x00FF0000, 0x0000FF00, 0x000000FF, 0xFF000000); // upload to sdl

            return iconSurface;
        }

        public void paintGreen()
        {
            SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
            SDL.SDL_RenderClear(renderer);
            SDL.SDL_RenderPresent(renderer);
        }
    }
}

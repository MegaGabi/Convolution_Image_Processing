using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convo_test
{
    public partial class wnd_Convo : Form
    {
        enum ConvoArrayNames { ReverseSlash, Slash, VerticalLine, HorizontalLine, Star, Cross };
        int[][,] Convolution = new int[][,]
        {
            new int[,]
            {
                 {  0,  1, 2},
                 { -1,  0, 1},
                 { -2, -1, 0},
            },
            new int[,]
            {
                 { 2,  1,  0},
                 { 1,  0, -1},
                 { 0, -1, -2},
            },
            new int[,]
            {
                 { -1, 0, 1},
                 { -2, 0, 2},
                 { -1, 0, 1},
            },
            new int[,]
            {
                 { -1, -2, -1},
                 {  0,  0,  0},
                 {  1,  2,  1},
            },
            new int[,]
            {
                 { -1, -1, -1},
                 { -1,  8, -1},
                 { -1, -1, -1},
            },
            new int[,]
            {
                 {  0, -1,  0},
                 { -1,  4, -1},
                 {  0, -1,  0},
            }
        };

        double[,] GaussianK;

        private double[,] GenerateGaussianKernel(double theta, int KernelSize)
        {
            double[,] GaussianKernel = new double[KernelSize, KernelSize];

            for (int i = 0; i < KernelSize; i++)
            {
                for (int j = 0; j < KernelSize; j++)
                {
                    int By = (KernelSize / 2) - i;
                    int Bx = -(KernelSize / 2) + j;

                    double GaussianBlurValue =
                        1 / (2 * Math.PI * Math.Pow(theta, 2))
                        * Math.Pow(Math.E, -(Math.Pow(Bx, 2) + Math.Pow(By, 2)) / (2 * Math.Pow(theta, 2)));

                    GaussianKernel[i, j] = GaussianBlurValue;
                }
            }

            return GaussianKernel;
        }

        public wnd_Convo()
        {
            InitializeComponent();

            GaussianK = GenerateGaussianKernel(1.4, 5);
        }

        private void pb_ToInsert_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void pb_ToInsert_DragDrop(object sender, DragEventArgs e)
        {
            if (pb_ToInsert.ClientRectangle.Contains(pb_ToInsert.PointToClient(Control.MousePosition)))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length != 0)
                {
                    string picture = files[0];

                    Bitmap bmp = new Bitmap(Image.FromFile(picture), pb_ToInsert.Size.Width, pb_ToInsert.Size.Height);
                    pb_ToInsert.Image = bmp;

                    pb_BwImage.Image = ImageToBW(pb_ToInsert.Image);

                    Bitmap b = new Bitmap(pb_BwImage.Image);
                    GaussianBlur(ref b, GaussianK);

                    pb_Blured.Image = b;
                }
            }
        }

        private Bitmap AddTwoBWImages(Bitmap f, Bitmap s)
        {
            if (f.Size != s.Size)
                return null;

            Bitmap res = new Bitmap(f.Width, f.Height);

            for(int i = 0; i < res.Height; i++)
            {
                for (int j = 0; j < res.Width; j++)
                {
                    int rgb = (int)Math.Sqrt((Math.Pow(f.GetPixel(j,i).R, 2) + Math.Pow(s.GetPixel(j, i).R, 2)));
                    rgb = (rgb > 255 ? 255 : rgb);
                    res.SetPixel(j,i,Color.FromArgb(rgb, rgb, rgb));
                }
            }

            return res;
        }

        private void NonMaximumSupression(ref Bitmap toCompute, int maskSize)
        {
            for (int y = 0; y < toCompute.Height; y++)
            {
                for (int x = 0; x < toCompute.Width; x++)
                {
                    int maximum = 0;

                    for (int i = 0; i < maskSize; i++)
                    {
                        for (int j = 0; j < maskSize; j++)
                        {
                            if (x + j < toCompute.Width && y + i < toCompute.Height)
                            {
                                if (toCompute.GetPixel(x + j, y + i).R > maximum)
                                {
                                    maximum = toCompute.GetPixel(x + j, y + i).R;
                                }
                            }
                        }
                    }

                    for (int i = 0; i < maskSize; i++)
                    {
                        for (int j = 0; j < maskSize; j++)
                        {
                            if (x + j < toCompute.Width && y + i < toCompute.Height)
                            {
                                if (toCompute.GetPixel(x + j, y + i).R != maximum)
                                {
                                    toCompute.SetPixel(x + j, y + i, Color.Black);
                                }
                            }
                        }
                    }
                }
            }
        } //бред

        private Image ImageToBW(Image img)
        {
            Bitmap res = new Bitmap(img);

            for(int x = 0; x < res.Width; x++)
            {
                for (int y = 0; y < res.Height; y++)
                {
                    Color clr = res.GetPixel(x, y);

                    int rgb = (clr.R + clr.G + clr.B) / 3;
                    res.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            }

            return res;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (pb_BwImage.Image == null) return;

            Bitmap imgToProcess = new Bitmap(pb_Blured.Image);

            
            if (sender == btn_reverseSlash)
            {
                BackgroundConvolution(imgToProcess, 
                            ((object s, DoWorkEventArgs ret) =>
                             ret.Result = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.ReverseSlash])
                            ));
            }
            else if (sender == btn_Slash)
            {
                BackgroundConvolution(imgToProcess,
                            ((object s, DoWorkEventArgs ret) =>
                             ret.Result = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.Slash])
                            ));
            }
            else if (sender == btn_StraightLine)
            {
                BackgroundConvolution(imgToProcess,
                            ((object s, DoWorkEventArgs ret) =>
                             ret.Result = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.VerticalLine])
                            ));
            }
            else if (sender == btn_HorizontalLine)
            {
                BackgroundConvolution(imgToProcess,
                            ((object s, DoWorkEventArgs ret) =>
                             ret.Result = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.HorizontalLine])
                            ));
            }
            else if (sender == btn_Star)
            {
                BackgroundConvolution(imgToProcess,
                            ((object s, DoWorkEventArgs ret) =>
                            {
                                Bitmap HorizontalResult = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.HorizontalLine]);
                                Bitmap VerticalResult = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.VerticalLine]);

                                Bitmap SlashResult = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.Slash]);
                                Bitmap ReverseSlashResult = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.ReverseSlash]);

                                Bitmap cross = AddTwoBWImages(HorizontalResult, VerticalResult);
                                Bitmap x = AddTwoBWImages(SlashResult, ReverseSlashResult);

                                ret.Result = AddTwoBWImages(cross, x);
                            }
                            ));
            }
            else if (sender == btn_Cross)
            {
                BackgroundConvolution(imgToProcess,
                            ((object s, DoWorkEventArgs ret) =>
                            {
                                Bitmap HorizontalResult = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.HorizontalLine]);
                                Bitmap VerticalResult = ApplyConvToPicture(imgToProcess, Convolution[(int)ConvoArrayNames.VerticalLine]);

                                ret.Result = AddTwoBWImages(HorizontalResult, VerticalResult);
                            }
                            ));
            }
        }

        private void BackgroundConvolution(Bitmap imgToProcess, DoWorkEventHandler method)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += method;
            bw.RunWorkerCompleted += ((object sender, RunWorkerCompletedEventArgs e) => pb_ConvoRes.Image = new Bitmap((Bitmap)e.Result));
            bw.RunWorkerAsync();
        }

        private Bitmap ApplyConvToPicture(Bitmap imgToProcess, int[,] v)
        {
            Bitmap res = new Bitmap(imgToProcess.Width / v.GetLength(1) + 1, imgToProcess.Height / v.GetLength(0) + 1);

            int brd = v.GetLength(0) / 2;
            imgToProcess = new Bitmap(imgToProcess, imgToProcess.Width + v.GetLength(1), imgToProcess.Height + v.GetLength(0));

            for (int y = 0; y < imgToProcess.Height - brd - 1; y++)
            {
                for (int x = 0; x < imgToProcess.Width - brd - 1; x++)
                {
                    int rgb = 0;
                    //конволюция
                    for(int i = 0; i < v.GetLength(0); i++)
                    {
                        for (int j = 0; j < v.GetLength(1); j++)
                        {
                            rgb += imgToProcess.GetPixel(x + j, y + i).R * v[i,j];
                        }
                    }
                    rgb /= v.Length;

                    rgb %= 255;
                    rgb = rgb < 0 ? 0 : rgb;

                    res.SetPixel(x / v.GetLength(1), y / v.GetLength(0), Color.FromArgb(rgb, rgb, rgb));
                }
            }

            //NonMaximumSupression(ref res, 5);

            return res;
        }

        private void GaussianBlur(ref Bitmap toBlur, double[,] Kernel)
        {
            Bitmap res = new Bitmap(toBlur);

            int GKernelY = Kernel.GetLength(0);
            int GKernelX = Kernel.GetLength(1);

            int gaussianSize = GKernelY * GKernelX;

            for (int y = 0; y < toBlur.Height; y++)
            {
                for (int x = 0; x < toBlur.Width; x++)
                {
                    double rgb = 0;
                    for (int i = 0; i < GKernelY; i++)
                    {
                        for (int j = 0; j < GKernelX; j++)
                        {
                            int XtoGet = x + j >= toBlur.Width ? toBlur.Width - 1 : x + j;
                            int YtoGet = y + i >= toBlur.Height ? toBlur.Height - 1 : y + i;

                            rgb += toBlur.GetPixel(XtoGet, YtoGet).R * Kernel[i,j];
                        }
                    }

                    //rgb *= (blurSize / 1.5);
                    rgb = rgb > 255 ? 255 : rgb;

                    res.SetPixel(x, y, Color.FromArgb((int)rgb, (int)rgb, (int)rgb));
               }
            }
            toBlur = res;
       }
    }
}

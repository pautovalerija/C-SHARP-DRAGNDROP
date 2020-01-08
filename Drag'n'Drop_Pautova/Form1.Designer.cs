using System.Drawing;

namespace Drag_n_Drop_Pautova
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 440);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.Paint += PictureBox1_Paint;
            this.pictureBox1.MouseDown += PictureBox1_MouseDown;
            this.pictureBox1.MouseMove += PictureBox1_MouseMove;
            this.pictureBox1.MouseUp += PictureBox1_MouseUp;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(31, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(285, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 79);
            this.label2.TabIndex = 2;
            this.label2.Text = "Форма";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(536, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 79);
            this.label3.TabIndex = 3;
            this.label3.Text = "Информация";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        private void PictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            c = false;
            r = false;
            s = false;

            if (LastClicked == 2)
            {
                if ((label2.Location.X < Circle.X + Circle.Width) && (label2.Location.X > Circle.X))
                {
                    if((label2.Location.Y < Circle.Y + Circle.Height) && (label2.Location.Y > Circle.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX;
                        dY = CircleY;
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        CircleX = SquareX;
                        CircleY = SquareY;

                        Square.X = X;
                        Square.Y = Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }
        }

        private void PictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (c)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
                pictureBox1.Invalidate();
            }
            if (r)
            {
                Rectangle.X = e.X - RectangleX;
                Rectangle.Y = e.Y - RectangleY;
                pictureBox1.Invalidate();
            }
            if (s)
            {
                Square.X = e.X - SquareX;
                Square.Y = e.Y - SquareY;
                pictureBox1.Invalidate();
            }

            if ((label1.Location.X < Square.X + Square.Width) && (label1.Location.X > Square.X))
            {
                if ((label1.Location.Y < Square.Y + Square.Height) && (label1.Location.Y > Square.Y))
                {
                    label3.Text = "Синий квадрат";
                }
            }
            if ((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X))
            {
                if ((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    label3.Text = "Желтый прямоугольник";
                }
            }
            if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if ((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label3.Text = "Крастный круг";
                }
            }
            pictureBox1.Invalidate();
        }

        private void PictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    LastClicked = 1;
                    r = true;
                    RectangleX = e.X - Rectangle.X;
                    RectangleY = e.Y - Rectangle.Y;
                }
            }
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    LastClicked = 2;
                    s = true;
                    SquareX = e.X - Square.X;
                    SquareY = e.Y - Square.Y;
                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    LastClicked = 3;
                    c = true;
                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;
                }
            }
        }

        private void PictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


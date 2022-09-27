using System;
using System.Drawing;
namespace Сапёр
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_start_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start_game
            // 
            this.btn_start_game.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start_game.Location = new System.Drawing.Point(140, 25);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(220, 50);
            this.btn_start_game.TabIndex = 0;
            this.btn_start_game.Text = "Начать игру";
            this.btn_start_game.UseVisualStyleBackColor = true;
            this.btn_start_game.Click += new System.EventHandler(this.start_game_pushed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 600);
            this.Controls.Add(this.btn_start_game);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

            for (int i = 0; i < 10; i += 1)
            {
                for (int j = 0; j < 10; j += 1)
                {
                    this.btn = new System.Windows.Forms.Button();
                    this.SuspendLayout();
                    this.btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    this.btn.Location = new System.Drawing.Point(15 + i * 50, 100 + j * 50);
                    this.btn.Name = Convert.ToString(j * 6 + i);
                    this.btn.Size = new System.Drawing.Size(40, 40);
                    this.btn.TabIndex = 0;
                    this.btn.Text = Convert.ToString(j * 6 + i + 1);
                    this.btn.BackColor = Color.Black;
                    //this.btn.UseVisualStyleBackColor = true;
                    this.Controls.Add(this.btn);
                }
            }

        }

        #endregion

        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Button btn;
    }
}


﻿
namespace Курсач
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbRazbros = new System.Windows.Forms.TrackBar();
            this.lblRazbros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGraviton = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGraviton1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKryg = new System.Windows.Forms.Label();
            this.lblKryg1 = new System.Windows.Forms.Label();
            this.tbSchet = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRazbros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSchet)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(13, 18);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(988, 572);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(13, 593);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(160, 56);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(180, 593);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 17);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.UseMnemonic = false;
            // 
            // tbRazbros
            // 
            this.tbRazbros.Location = new System.Drawing.Point(214, 598);
            this.tbRazbros.Maximum = 359;
            this.tbRazbros.Name = "tbRazbros";
            this.tbRazbros.Size = new System.Drawing.Size(160, 56);
            this.tbRazbros.TabIndex = 3;
            this.tbRazbros.Scroll += new System.EventHandler(this.tbRazbros_Scroll);
            // 
            // lblRazbros
            // 
            this.lblRazbros.AutoSize = true;
            this.lblRazbros.Location = new System.Drawing.Point(381, 598);
            this.lblRazbros.Name = "lblRazbros";
            this.lblRazbros.Size = new System.Drawing.Size(0, 17);
            this.lblRazbros.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Разброс";
            // 
            // tbGraviton
            // 
            this.tbGraviton.Location = new System.Drawing.Point(411, 593);
            this.tbGraviton.Maximum = 100;
            this.tbGraviton.Name = "tbGraviton";
            this.tbGraviton.Size = new System.Drawing.Size(152, 56);
            this.tbGraviton.TabIndex = 7;
            this.tbGraviton.Scroll += new System.EventHandler(this.tbGraviton_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Первый круг";
            // 
            // tbGraviton1
            // 
            this.tbGraviton1.Location = new System.Drawing.Point(596, 593);
            this.tbGraviton1.Maximum = 100;
            this.tbGraviton1.Name = "tbGraviton1";
            this.tbGraviton1.Size = new System.Drawing.Size(152, 56);
            this.tbGraviton1.TabIndex = 9;
            this.tbGraviton1.Scroll += new System.EventHandler(this.tbGraviton1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Второй круг";
            // 
            // lblKryg
            // 
            this.lblKryg.AutoSize = true;
            this.lblKryg.Location = new System.Drawing.Point(570, 593);
            this.lblKryg.Name = "lblKryg";
            this.lblKryg.Size = new System.Drawing.Size(0, 17);
            this.lblKryg.TabIndex = 11;
            // 
            // lblKryg1
            // 
            this.lblKryg1.AutoSize = true;
            this.lblKryg1.Location = new System.Drawing.Point(755, 598);
            this.lblKryg1.Name = "lblKryg1";
            this.lblKryg1.Size = new System.Drawing.Size(0, 17);
            this.lblKryg1.TabIndex = 12;
            // 
            // tbSchet
            // 
            this.tbSchet.Location = new System.Drawing.Point(784, 598);
            this.tbSchet.Maximum = 100;
            this.tbSchet.Name = "tbSchet";
            this.tbSchet.Size = new System.Drawing.Size(152, 56);
            this.tbSchet.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 664);
            this.Controls.Add(this.tbSchet);
            this.Controls.Add(this.lblKryg1);
            this.Controls.Add(this.lblKryg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGraviton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGraviton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRazbros);
            this.Controls.Add(this.tbRazbros);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRazbros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSchet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbRazbros;
        private System.Windows.Forms.Label lblRazbros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbGraviton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbGraviton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKryg;
        private System.Windows.Forms.Label lblKryg1;
        private System.Windows.Forms.TrackBar tbSchet;
    }
}


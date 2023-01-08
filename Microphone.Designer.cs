namespace VTubeMua
{
    partial class Microphone
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.volumeBar = new System.Windows.Forms.ProgressBar();
            this.inputSelect = new System.Windows.Forms.DomainUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.amplifyBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.amplifyBar)).BeginInit();
            this.SuspendLayout();
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.SystemColors.Control;
            this.volumeBar.Location = new System.Drawing.Point(10, 33);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(430, 25);
            this.volumeBar.TabIndex = 0;
            // 
            // inputSelect
            // 
            this.inputSelect.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputSelect.Location = new System.Drawing.Point(10, 66);
            this.inputSelect.Name = "inputSelect";
            this.inputSelect.ReadOnly = true;
            this.inputSelect.Size = new System.Drawing.Size(430, 24);
            this.inputSelect.TabIndex = 1;
            this.inputSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSelect.SelectedItemChanged += new System.EventHandler(this.InputSelect_SelectedItemChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // amplifyBar
            // 
            this.amplifyBar.BackColor = System.Drawing.Color.Black;
            this.amplifyBar.Location = new System.Drawing.Point(3, 10);
            this.amplifyBar.Maximum = 100;
            this.amplifyBar.Name = "amplifyBar";
            this.amplifyBar.Size = new System.Drawing.Size(444, 45);
            this.amplifyBar.TabIndex = 2;
            this.amplifyBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.amplifyBar.Value = 20;
            // 
            // Microphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.inputSelect);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.amplifyBar);
            this.Name = "Microphone";
            this.Size = new System.Drawing.Size(448, 98);
            ((System.ComponentModel.ISupportInitialize)(this.amplifyBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar volumeBar;
        private System.Windows.Forms.DomainUpDown inputSelect;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar amplifyBar;
    }
}

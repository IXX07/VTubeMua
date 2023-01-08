namespace VTubeMua
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.hideControlsButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.screamingBox = new System.Windows.Forms.PictureBox();
            this.talkingBox = new System.Windows.Forms.PictureBox();
            this.eyesClosedBox = new System.Windows.Forms.PictureBox();
            this.standardBox = new System.Windows.Forms.PictureBox();
            this.screamingLabel = new System.Windows.Forms.Label();
            this.talkingLabel = new System.Windows.Forms.Label();
            this.eyesClosedLabel = new System.Windows.Forms.Label();
            this.standardLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.microphone = new VTubeMua.Microphone();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.changeColorButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screamingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyesClosedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hideControlsButton
            // 
            this.hideControlsButton.BackColor = System.Drawing.Color.Black;
            this.hideControlsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideControlsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.hideControlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideControlsButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideControlsButton.ForeColor = System.Drawing.Color.White;
            this.hideControlsButton.Location = new System.Drawing.Point(690, 410);
            this.hideControlsButton.Name = "hideControlsButton";
            this.hideControlsButton.Size = new System.Drawing.Size(100, 30);
            this.hideControlsButton.TabIndex = 2;
            this.hideControlsButton.Text = "hide controls";
            this.hideControlsButton.UseVisualStyleBackColor = false;
            this.hideControlsButton.Click += new System.EventHandler(this.HideControlsButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bottomPanel.Controls.Add(this.screamingBox);
            this.bottomPanel.Controls.Add(this.talkingBox);
            this.bottomPanel.Controls.Add(this.eyesClosedBox);
            this.bottomPanel.Controls.Add(this.standardBox);
            this.bottomPanel.Controls.Add(this.screamingLabel);
            this.bottomPanel.Controls.Add(this.talkingLabel);
            this.bottomPanel.Controls.Add(this.eyesClosedLabel);
            this.bottomPanel.Controls.Add(this.standardLabel);
            this.bottomPanel.Location = new System.Drawing.Point(215, 350);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(370, 100);
            this.bottomPanel.TabIndex = 8;
            // 
            // screamingBox
            // 
            this.screamingBox.BackColor = System.Drawing.Color.Black;
            this.screamingBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("screamingBox.BackgroundImage")));
            this.screamingBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.screamingBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screamingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screamingBox.Location = new System.Drawing.Point(280, 20);
            this.screamingBox.Name = "screamingBox";
            this.screamingBox.Size = new System.Drawing.Size(80, 80);
            this.screamingBox.TabIndex = 15;
            this.screamingBox.TabStop = false;
            this.screamingBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // talkingBox
            // 
            this.talkingBox.BackColor = System.Drawing.Color.Black;
            this.talkingBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("talkingBox.BackgroundImage")));
            this.talkingBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.talkingBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.talkingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.talkingBox.Location = new System.Drawing.Point(190, 20);
            this.talkingBox.Name = "talkingBox";
            this.talkingBox.Size = new System.Drawing.Size(80, 80);
            this.talkingBox.TabIndex = 14;
            this.talkingBox.TabStop = false;
            this.talkingBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // eyesClosedBox
            // 
            this.eyesClosedBox.BackColor = System.Drawing.Color.Black;
            this.eyesClosedBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyesClosedBox.BackgroundImage")));
            this.eyesClosedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyesClosedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyesClosedBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyesClosedBox.Location = new System.Drawing.Point(100, 20);
            this.eyesClosedBox.Name = "eyesClosedBox";
            this.eyesClosedBox.Size = new System.Drawing.Size(80, 80);
            this.eyesClosedBox.TabIndex = 14;
            this.eyesClosedBox.TabStop = false;
            this.eyesClosedBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // standardBox
            // 
            this.standardBox.BackColor = System.Drawing.Color.Black;
            this.standardBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("standardBox.BackgroundImage")));
            this.standardBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.standardBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.standardBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standardBox.Location = new System.Drawing.Point(10, 20);
            this.standardBox.Name = "standardBox";
            this.standardBox.Size = new System.Drawing.Size(80, 80);
            this.standardBox.TabIndex = 13;
            this.standardBox.TabStop = false;
            this.standardBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // screamingLabel
            // 
            this.screamingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screamingLabel.ForeColor = System.Drawing.Color.White;
            this.screamingLabel.Location = new System.Drawing.Point(280, 3);
            this.screamingLabel.Name = "screamingLabel";
            this.screamingLabel.Size = new System.Drawing.Size(80, 16);
            this.screamingLabel.TabIndex = 12;
            this.screamingLabel.Text = "screaming";
            this.screamingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // talkingLabel
            // 
            this.talkingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talkingLabel.ForeColor = System.Drawing.Color.White;
            this.talkingLabel.Location = new System.Drawing.Point(190, 3);
            this.talkingLabel.Name = "talkingLabel";
            this.talkingLabel.Size = new System.Drawing.Size(80, 16);
            this.talkingLabel.TabIndex = 11;
            this.talkingLabel.Text = "talking";
            this.talkingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eyesClosedLabel
            // 
            this.eyesClosedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyesClosedLabel.ForeColor = System.Drawing.Color.White;
            this.eyesClosedLabel.Location = new System.Drawing.Point(100, 3);
            this.eyesClosedLabel.Name = "eyesClosedLabel";
            this.eyesClosedLabel.Size = new System.Drawing.Size(80, 16);
            this.eyesClosedLabel.TabIndex = 10;
            this.eyesClosedLabel.Text = "eyes closed";
            this.eyesClosedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // standardLabel
            // 
            this.standardLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardLabel.ForeColor = System.Drawing.Color.White;
            this.standardLabel.Location = new System.Drawing.Point(10, 3);
            this.standardLabel.Name = "standardLabel";
            this.standardLabel.Size = new System.Drawing.Size(80, 16);
            this.standardLabel.TabIndex = 9;
            this.standardLabel.Text = "standard";
            this.standardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // microphone
            // 
            this.microphone.BackColor = System.Drawing.Color.Black;
            this.microphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.microphone.Location = new System.Drawing.Point(175, 0);
            this.microphone.Name = "microphone";
            this.microphone.Size = new System.Drawing.Size(450, 100);
            this.microphone.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // changeColorButton
            // 
            this.changeColorButton.BackColor = System.Drawing.Color.Black;
            this.changeColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.changeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeColorButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeColorButton.ForeColor = System.Drawing.Color.White;
            this.changeColorButton.Location = new System.Drawing.Point(10, 410);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(100, 30);
            this.changeColorButton.TabIndex = 9;
            this.changeColorButton.Text = "change color";
            this.changeColorButton.UseVisualStyleBackColor = false;
            this.changeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.Lime;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.changeColorButton);
            this.Controls.Add(this.hideControlsButton);
            this.Controls.Add(this.microphone);
            this.Controls.Add(this.bottomPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.SizeChanged += new System.EventHandler(this.MainControl_SizeChanged);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screamingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyesClosedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microphone microphone;
        private System.Windows.Forms.Button hideControlsButton;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label standardLabel;
        private System.Windows.Forms.Label eyesClosedLabel;
        private System.Windows.Forms.Label talkingLabel;
        private System.Windows.Forms.Label screamingLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        internal System.Windows.Forms.PictureBox standardBox;
        internal System.Windows.Forms.PictureBox eyesClosedBox;
        internal System.Windows.Forms.PictureBox screamingBox;
        internal System.Windows.Forms.PictureBox talkingBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button changeColorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

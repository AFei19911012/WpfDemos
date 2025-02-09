namespace Editor3D
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.comboColors = new System.Windows.Forms.ComboBox();
            this.comboDemo = new System.Windows.Forms.ComboBox();
            this.labelMouseInfo = new System.Windows.Forms.Label();
            this.comboRaster = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboMouse = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.checkPointSelection = new System.Windows.Forms.CheckBox();
            this.checkMirrorX = new System.Windows.Forms.CheckBox();
            this.checkMirrorY = new System.Windows.Forms.CheckBox();
            this.checkIncludeZeroZ = new System.Windows.Forms.CheckBox();
            this.editor3D = new Editor3D.Editor3DRenderer();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblInfo.Location = new System.Drawing.Point(7, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 12);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info";
            // 
            // comboColors
            // 
            this.comboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColors.FormattingEnabled = true;
            this.comboColors.Location = new System.Drawing.Point(9, 78);
            this.comboColors.MaxDropDownItems = 30;
            this.comboColors.Name = "comboColors";
            this.comboColors.Size = new System.Drawing.Size(121, 20);
            this.comboColors.TabIndex = 3;
            this.comboColors.SelectedIndexChanged += new System.EventHandler(this.comboColors_SelectedIndexChanged);
            // 
            // comboDemo
            // 
            this.comboDemo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDemo.FormattingEnabled = true;
            this.comboDemo.Location = new System.Drawing.Point(9, 24);
            this.comboDemo.MaxDropDownItems = 30;
            this.comboDemo.Name = "comboDemo";
            this.comboDemo.Size = new System.Drawing.Size(121, 20);
            this.comboDemo.TabIndex = 2;
            this.comboDemo.SelectedIndexChanged += new System.EventHandler(this.comboDemo_SelectedIndexChanged);
            // 
            // labelMouseInfo
            // 
            this.labelMouseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMouseInfo.AutoSize = true;
            this.labelMouseInfo.ForeColor = System.Drawing.Color.Blue;
            this.labelMouseInfo.Location = new System.Drawing.Point(137, 624);
            this.labelMouseInfo.Name = "labelMouseInfo";
            this.labelMouseInfo.Size = new System.Drawing.Size(65, 12);
            this.labelMouseInfo.TabIndex = 0;
            this.labelMouseInfo.Text = "Mouse Info";
            // 
            // comboRaster
            // 
            this.comboRaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRaster.FormattingEnabled = true;
            this.comboRaster.Location = new System.Drawing.Point(9, 114);
            this.comboRaster.MaxDropDownItems = 30;
            this.comboRaster.Name = "comboRaster";
            this.comboRaster.Size = new System.Drawing.Size(121, 20);
            this.comboRaster.TabIndex = 4;
            this.comboRaster.SelectedIndexChanged += new System.EventHandler(this.comboRaster_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "3D Demo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Color Scheme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Coordinate System:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rho";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Theta";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 622);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phi";
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(9, 235);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(121, 21);
            this.btnScreenshot.TabIndex = 10;
            this.btnScreenshot.Text = "Save Screenshot";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(9, 210);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 21);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset Position";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mouse Buttons:";
            // 
            // comboMouse
            // 
            this.comboMouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMouse.FormattingEnabled = true;
            this.comboMouse.Items.AddRange(new object[] {
            "Left Theta, Right Phi",
            "Left Theta and Phi",
            "Middle Theta and Phi"});
            this.comboMouse.Location = new System.Drawing.Point(9, 186);
            this.comboMouse.MaxDropDownItems = 30;
            this.comboMouse.Name = "comboMouse";
            this.comboMouse.Size = new System.Drawing.Size(121, 20);
            this.comboMouse.TabIndex = 8;
            this.comboMouse.SelectedIndexChanged += new System.EventHandler(this.comboMouse_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 638);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(807, 22);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.statusLabel.Size = new System.Drawing.Size(86, 17);
            this.statusLabel.Text = "Select a demo";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(9, 281);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(121, 21);
            this.btnDeselect.TabIndex = 12;
            this.btnDeselect.Text = "Remove Selection";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // checkPointSelection
            // 
            this.checkPointSelection.AutoSize = true;
            this.checkPointSelection.BackColor = System.Drawing.Color.Transparent;
            this.checkPointSelection.Location = new System.Drawing.Point(10, 261);
            this.checkPointSelection.Name = "checkPointSelection";
            this.checkPointSelection.Size = new System.Drawing.Size(114, 16);
            this.checkPointSelection.TabIndex = 11;
            this.checkPointSelection.Text = "Point Selection";
            this.checkPointSelection.UseVisualStyleBackColor = false;
            this.checkPointSelection.CheckedChanged += new System.EventHandler(this.checkPointSelection_CheckedChanged);
            // 
            // checkMirrorX
            // 
            this.checkMirrorX.AutoSize = true;
            this.checkMirrorX.BackColor = System.Drawing.Color.Transparent;
            this.checkMirrorX.Location = new System.Drawing.Point(9, 154);
            this.checkMirrorX.Name = "checkMirrorX";
            this.checkMirrorX.Size = new System.Drawing.Size(72, 16);
            this.checkMirrorX.TabIndex = 6;
            this.checkMirrorX.Text = "Mirror X";
            this.checkMirrorX.UseVisualStyleBackColor = false;
            this.checkMirrorX.CheckedChanged += new System.EventHandler(this.checkMirrorX_CheckedChanged);
            // 
            // checkMirrorY
            // 
            this.checkMirrorY.AutoSize = true;
            this.checkMirrorY.BackColor = System.Drawing.Color.Transparent;
            this.checkMirrorY.Location = new System.Drawing.Point(71, 154);
            this.checkMirrorY.Name = "checkMirrorY";
            this.checkMirrorY.Size = new System.Drawing.Size(72, 16);
            this.checkMirrorY.TabIndex = 7;
            this.checkMirrorY.Text = "Mirror Y";
            this.checkMirrorY.UseVisualStyleBackColor = false;
            this.checkMirrorY.CheckedChanged += new System.EventHandler(this.checkMirrorY_CheckedChanged);
            // 
            // checkIncludeZeroZ
            // 
            this.checkIncludeZeroZ.AutoSize = true;
            this.checkIncludeZeroZ.BackColor = System.Drawing.Color.Transparent;
            this.checkIncludeZeroZ.Checked = true;
            this.checkIncludeZeroZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIncludeZeroZ.Location = new System.Drawing.Point(9, 138);
            this.checkIncludeZeroZ.Name = "checkIncludeZeroZ";
            this.checkIncludeZeroZ.Size = new System.Drawing.Size(108, 16);
            this.checkIncludeZeroZ.TabIndex = 5;
            this.checkIncludeZeroZ.Text = "Include Zero Z";
            this.checkIncludeZeroZ.UseVisualStyleBackColor = false;
            this.checkIncludeZeroZ.CheckedChanged += new System.EventHandler(this.checkIncludeZeroZ_CheckedChanged);
            // 
            // editor3D
            // 
            this.editor3D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editor3D.BackColor = System.Drawing.Color.White;
            this.editor3D.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editor3D.BorderColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editor3D.Cursor = System.Windows.Forms.Cursors.Default;
            this.editor3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor3D.LegendPos = Editor3D.EnumLegendPos.BottomLeft;
            this.editor3D.Location = new System.Drawing.Point(139, 10);
            this.editor3D.Name = "editor3D";
            this.editor3D.Normalize = Editor3D.EnumNormalize.Separate;
            this.editor3D.Raster = Editor3D.EnumRaster.Off;
            this.editor3D.Size = new System.Drawing.Size(656, 610);
            this.editor3D.TabIndex = 1;
            this.editor3D.TooltipMode = ((Editor3D.EnumTooltip)((Editor3D.EnumTooltip.UserText | Editor3D.EnumTooltip.Coord)));
            this.editor3D.TopLegendColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 660);
            this.Controls.Add(this.checkIncludeZeroZ);
            this.Controls.Add(this.checkMirrorY);
            this.Controls.Add(this.checkMirrorX);
            this.Controls.Add(this.checkPointSelection);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboMouse);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboRaster);
            this.Controls.Add(this.labelMouseInfo);
            this.Controls.Add(this.comboDemo);
            this.Controls.Add(this.comboColors);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.editor3D);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 372);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Editor Demo";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Editor3D.Editor3DRenderer editor3D;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox comboColors;
        private System.Windows.Forms.ComboBox comboDemo;
        private System.Windows.Forms.Label labelMouseInfo;
        private System.Windows.Forms.ComboBox comboRaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboMouse;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.CheckBox checkPointSelection;
        private System.Windows.Forms.CheckBox checkMirrorX;
        private System.Windows.Forms.CheckBox checkMirrorY;
        private System.Windows.Forms.CheckBox checkIncludeZeroZ;

    }
}


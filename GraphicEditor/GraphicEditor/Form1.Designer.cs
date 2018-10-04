namespace GraphicEditor
{
    partial class MainForm
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
            this.rightSidebar = new System.Windows.Forms.ToolStrip();
            this.lineTextColor = new System.Windows.Forms.ToolStripLabel();
            this.textLine = new System.Windows.Forms.ToolStripLabel();
            this.lineWhiteBtn = new System.Windows.Forms.ToolStripButton();
            this.lineBlackBtn = new System.Windows.Forms.ToolStripButton();
            this.lineRedBtn = new System.Windows.Forms.ToolStripButton();
            this.lineBlueBtn = new System.Windows.Forms.ToolStripButton();
            this.lineYellowBtn = new System.Windows.Forms.ToolStripButton();
            this.lineGreenBtn = new System.Windows.Forms.ToolStripButton();
            this.lineMoreColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fillTextColor = new System.Windows.Forms.ToolStripLabel();
            this.textFill = new System.Windows.Forms.ToolStripLabel();
            this.fillWhiteBtn = new System.Windows.Forms.ToolStripButton();
            this.fillBlackBtn = new System.Windows.Forms.ToolStripButton();
            this.fillRedBtn = new System.Windows.Forms.ToolStripButton();
            this.fillBlueBtn = new System.Windows.Forms.ToolStripButton();
            this.fillYellowBtn = new System.Windows.Forms.ToolStripButton();
            this.fillGreenBtn = new System.Windows.Forms.ToolStripButton();
            this.fillMoreColorBtn = new System.Windows.Forms.ToolStripButton();
            this.rightSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightSidebar
            // 
            this.rightSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightSidebar.Dock = System.Windows.Forms.DockStyle.None;
            this.rightSidebar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.rightSidebar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightSidebar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineTextColor,
            this.textLine,
            this.lineWhiteBtn,
            this.lineBlackBtn,
            this.lineRedBtn,
            this.lineBlueBtn,
            this.lineYellowBtn,
            this.lineGreenBtn,
            this.lineMoreColorBtn,
            this.toolStripSeparator1,
            this.fillTextColor,
            this.textFill,
            this.fillWhiteBtn,
            this.fillBlackBtn,
            this.fillRedBtn,
            this.fillBlueBtn,
            this.fillYellowBtn,
            this.fillGreenBtn,
            this.fillMoreColorBtn});
            this.rightSidebar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.rightSidebar.Location = new System.Drawing.Point(1080, 9);
            this.rightSidebar.Name = "rightSidebar";
            this.rightSidebar.Size = new System.Drawing.Size(69, 478);
            this.rightSidebar.TabIndex = 0;
            this.rightSidebar.Text = "rightSidebar";
            // 
            // lineTextColor
            // 
            this.lineTextColor.Name = "lineTextColor";
            this.lineTextColor.Size = new System.Drawing.Size(67, 20);
            this.lineTextColor.Text = "Цвет";
            // 
            // textLine
            // 
            this.textLine.Name = "textLine";
            this.textLine.Size = new System.Drawing.Size(67, 20);
            this.textLine.Text = "линии:";
            // 
            // lineWhiteBtn
            // 
            this.lineWhiteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineWhiteBtn.Image = global::GraphicEditor.Properties.Resources.white;
            this.lineWhiteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineWhiteBtn.Name = "lineWhiteBtn";
            this.lineWhiteBtn.Size = new System.Drawing.Size(67, 24);
            this.lineWhiteBtn.Text = "Белый";
            // 
            // lineBlackBtn
            // 
            this.lineBlackBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineBlackBtn.Image = global::GraphicEditor.Properties.Resources.black;
            this.lineBlackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineBlackBtn.Name = "lineBlackBtn";
            this.lineBlackBtn.Size = new System.Drawing.Size(67, 24);
            this.lineBlackBtn.Text = "Черный";
            // 
            // lineRedBtn
            // 
            this.lineRedBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineRedBtn.Image = global::GraphicEditor.Properties.Resources.red;
            this.lineRedBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineRedBtn.Name = "lineRedBtn";
            this.lineRedBtn.Size = new System.Drawing.Size(67, 24);
            this.lineRedBtn.Text = "Красный";
            // 
            // lineBlueBtn
            // 
            this.lineBlueBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineBlueBtn.Image = global::GraphicEditor.Properties.Resources.blue;
            this.lineBlueBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineBlueBtn.Name = "lineBlueBtn";
            this.lineBlueBtn.Size = new System.Drawing.Size(67, 24);
            this.lineBlueBtn.Text = "Синий";
            // 
            // lineYellowBtn
            // 
            this.lineYellowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineYellowBtn.Image = global::GraphicEditor.Properties.Resources.yellow;
            this.lineYellowBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineYellowBtn.Name = "lineYellowBtn";
            this.lineYellowBtn.Size = new System.Drawing.Size(67, 24);
            this.lineYellowBtn.Text = "Желтый";
            // 
            // lineGreenBtn
            // 
            this.lineGreenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineGreenBtn.Image = global::GraphicEditor.Properties.Resources.green;
            this.lineGreenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineGreenBtn.Name = "lineGreenBtn";
            this.lineGreenBtn.Size = new System.Drawing.Size(67, 24);
            this.lineGreenBtn.Text = "Зеленый";
            // 
            // lineMoreColorBtn
            // 
            this.lineMoreColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineMoreColorBtn.Image = global::GraphicEditor.Properties.Resources.Apps_preferences_color_icon;
            this.lineMoreColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineMoreColorBtn.Name = "lineMoreColorBtn";
            this.lineMoreColorBtn.Size = new System.Drawing.Size(67, 24);
            this.lineMoreColorBtn.Text = "Палитра";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(67, 6);
            // 
            // fillTextColor
            // 
            this.fillTextColor.Name = "fillTextColor";
            this.fillTextColor.Size = new System.Drawing.Size(67, 20);
            this.fillTextColor.Text = "Цвет";
            // 
            // textFill
            // 
            this.textFill.Name = "textFill";
            this.textFill.Size = new System.Drawing.Size(67, 20);
            this.textFill.Text = "заливки:";
            // 
            // fillWhiteBtn
            // 
            this.fillWhiteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillWhiteBtn.Image = global::GraphicEditor.Properties.Resources.white;
            this.fillWhiteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillWhiteBtn.Name = "fillWhiteBtn";
            this.fillWhiteBtn.Size = new System.Drawing.Size(67, 24);
            this.fillWhiteBtn.Text = "Белый";
            // 
            // fillBlackBtn
            // 
            this.fillBlackBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillBlackBtn.Image = global::GraphicEditor.Properties.Resources.black;
            this.fillBlackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillBlackBtn.Name = "fillBlackBtn";
            this.fillBlackBtn.Size = new System.Drawing.Size(67, 24);
            this.fillBlackBtn.Text = "Черный";
            // 
            // fillRedBtn
            // 
            this.fillRedBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillRedBtn.Image = global::GraphicEditor.Properties.Resources.red;
            this.fillRedBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillRedBtn.Name = "fillRedBtn";
            this.fillRedBtn.Size = new System.Drawing.Size(67, 24);
            this.fillRedBtn.Text = "Красный";
            // 
            // fillBlueBtn
            // 
            this.fillBlueBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillBlueBtn.Image = global::GraphicEditor.Properties.Resources.blue;
            this.fillBlueBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillBlueBtn.Name = "fillBlueBtn";
            this.fillBlueBtn.Size = new System.Drawing.Size(67, 24);
            this.fillBlueBtn.Text = "Синий";
            // 
            // fillYellowBtn
            // 
            this.fillYellowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillYellowBtn.Image = global::GraphicEditor.Properties.Resources.yellow;
            this.fillYellowBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillYellowBtn.Name = "fillYellowBtn";
            this.fillYellowBtn.Size = new System.Drawing.Size(67, 24);
            this.fillYellowBtn.Text = "Желтый";
            // 
            // fillGreenBtn
            // 
            this.fillGreenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillGreenBtn.Image = global::GraphicEditor.Properties.Resources.green;
            this.fillGreenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillGreenBtn.Name = "fillGreenBtn";
            this.fillGreenBtn.Size = new System.Drawing.Size(67, 24);
            this.fillGreenBtn.Text = "Зеленый";
            // 
            // fillMoreColorBtn
            // 
            this.fillMoreColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillMoreColorBtn.Image = global::GraphicEditor.Properties.Resources.Apps_preferences_color_icon;
            this.fillMoreColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillMoreColorBtn.Name = "fillMoreColorBtn";
            this.fillMoreColorBtn.Size = new System.Drawing.Size(67, 24);
            this.fillMoreColorBtn.Text = "Палитра";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 660);
            this.Controls.Add(this.rightSidebar);
            this.Name = "MainForm";
            this.Text = "GraphicEditor";
            this.rightSidebar.ResumeLayout(false);
            this.rightSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip rightSidebar;
        private System.Windows.Forms.ToolStripLabel lineTextColor;
        private System.Windows.Forms.ToolStripLabel textLine;
        private System.Windows.Forms.ToolStripButton lineWhiteBtn;
        private System.Windows.Forms.ToolStripButton lineBlackBtn;
        private System.Windows.Forms.ToolStripButton lineRedBtn;
        private System.Windows.Forms.ToolStripButton lineBlueBtn;
        private System.Windows.Forms.ToolStripButton lineYellowBtn;
        private System.Windows.Forms.ToolStripButton lineGreenBtn;
        private System.Windows.Forms.ToolStripButton lineMoreColorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel fillTextColor;
        private System.Windows.Forms.ToolStripLabel textFill;
        private System.Windows.Forms.ToolStripButton fillWhiteBtn;
        private System.Windows.Forms.ToolStripButton fillBlackBtn;
        private System.Windows.Forms.ToolStripButton fillRedBtn;
        private System.Windows.Forms.ToolStripButton fillBlueBtn;
        private System.Windows.Forms.ToolStripButton fillYellowBtn;
        private System.Windows.Forms.ToolStripButton fillGreenBtn;
        private System.Windows.Forms.ToolStripButton fillMoreColorBtn;
    }
}


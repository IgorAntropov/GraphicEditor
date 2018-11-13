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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RightSidebar = new System.Windows.Forms.ToolStrip();
            this.LineTextColor = new System.Windows.Forms.ToolStripLabel();
            this.TextLine = new System.Windows.Forms.ToolStripLabel();
            this.LineWhiteBtn = new System.Windows.Forms.ToolStripButton();
            this.LineBlackBtn = new System.Windows.Forms.ToolStripButton();
            this.LineRedBtn = new System.Windows.Forms.ToolStripButton();
            this.LineBlueBtn = new System.Windows.Forms.ToolStripButton();
            this.LineYellowBtn = new System.Windows.Forms.ToolStripButton();
            this.LineGreenBtn = new System.Windows.Forms.ToolStripButton();
            this.LineMoreColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FillTextColor = new System.Windows.Forms.ToolStripLabel();
            this.TextFill = new System.Windows.Forms.ToolStripLabel();
            this.FillWhiteBtn = new System.Windows.Forms.ToolStripButton();
            this.FillBlackBtn = new System.Windows.Forms.ToolStripButton();
            this.FillRedBtn = new System.Windows.Forms.ToolStripButton();
            this.FillBlueBtn = new System.Windows.Forms.ToolStripButton();
            this.FillYellowBtn = new System.Windows.Forms.ToolStripButton();
            this.FillGreenBtn = new System.Windows.Forms.ToolStripButton();
            this.FillMoreColorBtn = new System.Windows.Forms.ToolStripButton();
            this.TopMenu = new System.Windows.Forms.ToolStrip();
            this.ClrBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CursorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TextShapes = new System.Windows.Forms.ToolStripLabel();
            this.LineBtn = new System.Windows.Forms.ToolStripButton();
            this.PolyLineBtn = new System.Windows.Forms.ToolStripButton();
            this.EllipseBtn = new System.Windows.Forms.ToolStripButton();
            this.RectangleBtn = new System.Windows.Forms.ToolStripButton();
            this.PolygonBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.LineType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TextSizeLine = new System.Windows.Forms.ToolStripLabel();
            this.LineSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.PrevArrowBtn = new System.Windows.Forms.ToolStripButton();
            this.NextArrowBtn = new System.Windows.Forms.ToolStripButton();
            this.DotX = new System.Windows.Forms.TextBox();
            this.DotY = new System.Windows.Forms.TextBox();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsProject = new System.Windows.Forms.ToolStripMenuItem();
            this.JpgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightSidebar.SuspendLayout();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightSidebar
            // 
            this.RightSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightSidebar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.RightSidebar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RightSidebar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineTextColor,
            this.TextLine,
            this.LineWhiteBtn,
            this.LineBlackBtn,
            this.LineRedBtn,
            this.LineBlueBtn,
            this.LineYellowBtn,
            this.LineGreenBtn,
            this.LineMoreColorBtn,
            this.toolStripSeparator1,
            this.FillTextColor,
            this.TextFill,
            this.FillWhiteBtn,
            this.FillBlackBtn,
            this.FillRedBtn,
            this.FillBlueBtn,
            this.FillYellowBtn,
            this.FillGreenBtn,
            this.FillMoreColorBtn});
            this.RightSidebar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.RightSidebar.Location = new System.Drawing.Point(1089, 28);
            this.RightSidebar.Name = "RightSidebar";
            this.RightSidebar.Size = new System.Drawing.Size(69, 632);
            this.RightSidebar.TabIndex = 0;
            this.RightSidebar.Text = "rightSidebar";
            // 
            // LineTextColor
            // 
            this.LineTextColor.Name = "LineTextColor";
            this.LineTextColor.Size = new System.Drawing.Size(66, 20);
            this.LineTextColor.Text = "Цвет";
            // 
            // TextLine
            // 
            this.TextLine.Name = "TextLine";
            this.TextLine.Size = new System.Drawing.Size(66, 20);
            this.TextLine.Text = "линии:";
            // 
            // LineWhiteBtn
            // 
            this.LineWhiteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineWhiteBtn.Image = global::GraphicEditor.Properties.Resources.white;
            this.LineWhiteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineWhiteBtn.Name = "LineWhiteBtn";
            this.LineWhiteBtn.Size = new System.Drawing.Size(66, 24);
            this.LineWhiteBtn.Text = "Белый";
            // 
            // LineBlackBtn
            // 
            this.LineBlackBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineBlackBtn.Image = global::GraphicEditor.Properties.Resources.black;
            this.LineBlackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineBlackBtn.Name = "LineBlackBtn";
            this.LineBlackBtn.Size = new System.Drawing.Size(66, 24);
            this.LineBlackBtn.Text = "Черный";
            // 
            // LineRedBtn
            // 
            this.LineRedBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineRedBtn.Image = global::GraphicEditor.Properties.Resources.red;
            this.LineRedBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineRedBtn.Name = "LineRedBtn";
            this.LineRedBtn.Size = new System.Drawing.Size(66, 24);
            this.LineRedBtn.Text = "Красный";
            // 
            // LineBlueBtn
            // 
            this.LineBlueBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineBlueBtn.Image = global::GraphicEditor.Properties.Resources.blue;
            this.LineBlueBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineBlueBtn.Name = "LineBlueBtn";
            this.LineBlueBtn.Size = new System.Drawing.Size(66, 24);
            this.LineBlueBtn.Text = "Синий";
            // 
            // LineYellowBtn
            // 
            this.LineYellowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineYellowBtn.Image = global::GraphicEditor.Properties.Resources.yellow;
            this.LineYellowBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineYellowBtn.Name = "LineYellowBtn";
            this.LineYellowBtn.Size = new System.Drawing.Size(66, 24);
            this.LineYellowBtn.Text = "Желтый";
            // 
            // LineGreenBtn
            // 
            this.LineGreenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineGreenBtn.Image = global::GraphicEditor.Properties.Resources.green;
            this.LineGreenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineGreenBtn.Name = "LineGreenBtn";
            this.LineGreenBtn.Size = new System.Drawing.Size(66, 24);
            this.LineGreenBtn.Text = "Зеленый";
            // 
            // LineMoreColorBtn
            // 
            this.LineMoreColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineMoreColorBtn.Image = global::GraphicEditor.Properties.Resources.Apps_preferences_color_icon;
            this.LineMoreColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineMoreColorBtn.Name = "LineMoreColorBtn";
            this.LineMoreColorBtn.Size = new System.Drawing.Size(66, 24);
            this.LineMoreColorBtn.Text = "Палитра";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(66, 6);
            // 
            // FillTextColor
            // 
            this.FillTextColor.Name = "FillTextColor";
            this.FillTextColor.Size = new System.Drawing.Size(66, 20);
            this.FillTextColor.Text = "Цвет";
            // 
            // TextFill
            // 
            this.TextFill.Name = "TextFill";
            this.TextFill.Size = new System.Drawing.Size(66, 20);
            this.TextFill.Text = "заливки:";
            // 
            // FillWhiteBtn
            // 
            this.FillWhiteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillWhiteBtn.Image = global::GraphicEditor.Properties.Resources.white;
            this.FillWhiteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillWhiteBtn.Name = "FillWhiteBtn";
            this.FillWhiteBtn.Size = new System.Drawing.Size(66, 24);
            this.FillWhiteBtn.Text = "Белый";
            // 
            // FillBlackBtn
            // 
            this.FillBlackBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillBlackBtn.Image = global::GraphicEditor.Properties.Resources.black;
            this.FillBlackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillBlackBtn.Name = "FillBlackBtn";
            this.FillBlackBtn.Size = new System.Drawing.Size(66, 24);
            this.FillBlackBtn.Text = "Черный";
            // 
            // FillRedBtn
            // 
            this.FillRedBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillRedBtn.Image = global::GraphicEditor.Properties.Resources.red;
            this.FillRedBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillRedBtn.Name = "FillRedBtn";
            this.FillRedBtn.Size = new System.Drawing.Size(66, 24);
            this.FillRedBtn.Text = "Красный";
            // 
            // FillBlueBtn
            // 
            this.FillBlueBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillBlueBtn.Image = global::GraphicEditor.Properties.Resources.blue;
            this.FillBlueBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillBlueBtn.Name = "FillBlueBtn";
            this.FillBlueBtn.Size = new System.Drawing.Size(66, 24);
            this.FillBlueBtn.Text = "Синий";
            // 
            // FillYellowBtn
            // 
            this.FillYellowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillYellowBtn.Image = global::GraphicEditor.Properties.Resources.yellow;
            this.FillYellowBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillYellowBtn.Name = "FillYellowBtn";
            this.FillYellowBtn.Size = new System.Drawing.Size(66, 24);
            this.FillYellowBtn.Text = "Желтый";
            // 
            // FillGreenBtn
            // 
            this.FillGreenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillGreenBtn.Image = global::GraphicEditor.Properties.Resources.green;
            this.FillGreenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillGreenBtn.Name = "FillGreenBtn";
            this.FillGreenBtn.Size = new System.Drawing.Size(66, 24);
            this.FillGreenBtn.Text = "Зеленый";
            // 
            // FillMoreColorBtn
            // 
            this.FillMoreColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillMoreColorBtn.Image = global::GraphicEditor.Properties.Resources.Apps_preferences_color_icon;
            this.FillMoreColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillMoreColorBtn.Name = "FillMoreColorBtn";
            this.FillMoreColorBtn.Size = new System.Drawing.Size(66, 24);
            this.FillMoreColorBtn.Text = "Палитра";
            // 
            // TopMenu
            // 
            this.TopMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClrBtn,
            this.toolStripSeparator2,
            this.SaveBtn,
            this.toolStripSeparator3,
            this.OpenBtn,
            this.toolStripSeparator4,
            this.CursorBtn,
            this.toolStripSeparator5,
            this.TextShapes,
            this.LineBtn,
            this.PolyLineBtn,
            this.EllipseBtn,
            this.RectangleBtn,
            this.PolygonBtn,
            this.toolStripSeparator6,
            this.LineType,
            this.toolStripSeparator7,
            this.TextSizeLine,
            this.LineSize,
            this.toolStripSeparator8,
            this.PrevArrowBtn,
            this.NextArrowBtn});
            this.TopMenu.Location = new System.Drawing.Point(0, 28);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1089, 28);
            this.TopMenu.TabIndex = 1;
            this.TopMenu.Text = "Меню";
            // 
            // ClrBtn
            // 
            this.ClrBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClrBtn.Image = global::GraphicEditor.Properties.Resources.wiping_swipe_for_floors;
            this.ClrBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(24, 25);
            this.ClrBtn.Text = "Очистить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // SaveBtn
            // 
            this.SaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveBtn.Image = global::GraphicEditor.Properties.Resources.diskette;
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(24, 25);
            this.SaveBtn.Text = "Сохранить";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // OpenBtn
            // 
            this.OpenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenBtn.Image = global::GraphicEditor.Properties.Resources.open_folder_with_file;
            this.OpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(24, 25);
            this.OpenBtn.Text = "Открыть";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // CursorBtn
            // 
            this.CursorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CursorBtn.Image = global::GraphicEditor.Properties.Resources.cursor;
            this.CursorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CursorBtn.Name = "CursorBtn";
            this.CursorBtn.Size = new System.Drawing.Size(24, 25);
            this.CursorBtn.Text = "Курсор";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // TextShapes
            // 
            this.TextShapes.Name = "TextShapes";
            this.TextShapes.Size = new System.Drawing.Size(65, 25);
            this.TextShapes.Text = "Фигуры:";
            // 
            // LineBtn
            // 
            this.LineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineBtn.Image = global::GraphicEditor.Properties.Resources.horizontal_line;
            this.LineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(24, 25);
            this.LineBtn.Text = "Линия";
            // 
            // PolyLineBtn
            // 
            this.PolyLineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolyLineBtn.Image = global::GraphicEditor.Properties.Resources.zig_zag_line_sign;
            this.PolyLineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolyLineBtn.Name = "PolyLineBtn";
            this.PolyLineBtn.Size = new System.Drawing.Size(24, 25);
            this.PolyLineBtn.Text = "Ломанная";
            // 
            // EllipseBtn
            // 
            this.EllipseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EllipseBtn.Image = global::GraphicEditor.Properties.Resources.ellipse_outline_shape_variant;
            this.EllipseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EllipseBtn.Name = "EllipseBtn";
            this.EllipseBtn.Size = new System.Drawing.Size(24, 25);
            this.EllipseBtn.Text = "Эллипс";
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleBtn.Image = global::GraphicEditor.Properties.Resources.rectangular_shape_outline;
            this.RectangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(24, 25);
            this.RectangleBtn.Text = "Прямоугольник";
            // 
            // PolygonBtn
            // 
            this.PolygonBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolygonBtn.Image = global::GraphicEditor.Properties.Resources.pentagon_;
            this.PolygonBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolygonBtn.Name = "PolygonBtn";
            this.PolygonBtn.Size = new System.Drawing.Size(24, 25);
            this.PolygonBtn.Text = "Многоугольник";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // LineType
            // 
            this.LineType.Items.AddRange(new object[] {
            "Сплошная",
            "Пунктирная",
            "Штрих-пунктирная"});
            this.LineType.Name = "LineType";
            this.LineType.Size = new System.Drawing.Size(121, 28);
            this.LineType.Text = "Тип линии";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // TextSizeLine
            // 
            this.TextSizeLine.Name = "TextSizeLine";
            this.TextSizeLine.Size = new System.Drawing.Size(123, 25);
            this.TextSizeLine.Text = "Толщина линии:";
            // 
            // LineSize
            // 
            this.LineSize.Name = "LineSize";
            this.LineSize.Size = new System.Drawing.Size(28, 28);
            this.LineSize.Text = "1";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 28);
            // 
            // PrevArrowBtn
            // 
            this.PrevArrowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrevArrowBtn.Image = global::GraphicEditor.Properties.Resources.left_pointing_arrow;
            this.PrevArrowBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrevArrowBtn.Name = "PrevArrowBtn";
            this.PrevArrowBtn.Size = new System.Drawing.Size(24, 25);
            this.PrevArrowBtn.Text = "Назад";
            // 
            // NextArrowBtn
            // 
            this.NextArrowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextArrowBtn.Image = global::GraphicEditor.Properties.Resources.right_arrow;
            this.NextArrowBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextArrowBtn.Name = "NextArrowBtn";
            this.NextArrowBtn.Size = new System.Drawing.Size(24, 25);
            this.NextArrowBtn.Text = "Вперед";
            // 
            // DotX
            // 
            this.DotX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DotX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DotX.Enabled = false;
            this.DotX.Location = new System.Drawing.Point(1093, 598);
            this.DotX.Name = "DotX";
            this.DotX.Size = new System.Drawing.Size(53, 22);
            this.DotX.TabIndex = 2;
            // 
            // DotY
            // 
            this.DotY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DotY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DotY.Enabled = false;
            this.DotY.Location = new System.Drawing.Point(1093, 626);
            this.DotY.Name = "DotY";
            this.DotY.Size = new System.Drawing.Size(53, 22);
            this.DotY.TabIndex = 3;
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(12, 64);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1065, 584);
            this.Canvas.TabIndex = 4;
            this.Canvas.TabStop = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProject});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1158, 28);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuProject
            // 
            this.MenuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenProject,
            this.SaveProject,
            this.SaveAsProject});
            this.MenuProject.Name = "MenuProject";
            this.MenuProject.Size = new System.Drawing.Size(71, 24);
            this.MenuProject.Text = "Проект";
            // 
            // OpenProject
            // 
            this.OpenProject.Name = "OpenProject";
            this.OpenProject.Size = new System.Drawing.Size(216, 26);
            this.OpenProject.Text = "Открыть проект";
            // 
            // SaveProject
            // 
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.Size = new System.Drawing.Size(216, 26);
            this.SaveProject.Text = "Сохранить проект";
            // 
            // SaveAsProject
            // 
            this.SaveAsProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JpgToolStripMenuItem,
            this.PngToolStripMenuItem,
            this.BmpToolStripMenuItem});
            this.SaveAsProject.Name = "SaveAsProject";
            this.SaveAsProject.Size = new System.Drawing.Size(216, 26);
            this.SaveAsProject.Text = "Сохранить как";
            // 
            // JpgToolStripMenuItem
            // 
            this.JpgToolStripMenuItem.Name = "JpgToolStripMenuItem";
            this.JpgToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.JpgToolStripMenuItem.Text = "Jpg";
            // 
            // PngToolStripMenuItem
            // 
            this.PngToolStripMenuItem.Name = "PngToolStripMenuItem";
            this.PngToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.PngToolStripMenuItem.Text = "Png";
            // 
            // BmpToolStripMenuItem
            // 
            this.BmpToolStripMenuItem.Name = "BmpToolStripMenuItem";
            this.BmpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.BmpToolStripMenuItem.Text = "Bmp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 660);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.DotY);
            this.Controls.Add(this.DotX);
            this.Controls.Add(this.TopMenu);
            this.Controls.Add(this.RightSidebar);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "GraphicEditor";
            this.RightSidebar.ResumeLayout(false);
            this.RightSidebar.PerformLayout();
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip RightSidebar;
        private System.Windows.Forms.ToolStripLabel LineTextColor;
        private System.Windows.Forms.ToolStripLabel TextLine;
        private System.Windows.Forms.ToolStripButton LineWhiteBtn;
        private System.Windows.Forms.ToolStripButton LineBlackBtn;
        private System.Windows.Forms.ToolStripButton LineRedBtn;
        private System.Windows.Forms.ToolStripButton LineBlueBtn;
        private System.Windows.Forms.ToolStripButton LineYellowBtn;
        private System.Windows.Forms.ToolStripButton LineGreenBtn;
        private System.Windows.Forms.ToolStripButton LineMoreColorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel FillTextColor;
        private System.Windows.Forms.ToolStripLabel TextFill;
        private System.Windows.Forms.ToolStripButton FillWhiteBtn;
        private System.Windows.Forms.ToolStripButton FillBlackBtn;
        private System.Windows.Forms.ToolStripButton FillRedBtn;
        private System.Windows.Forms.ToolStripButton FillBlueBtn;
        private System.Windows.Forms.ToolStripButton FillYellowBtn;
        private System.Windows.Forms.ToolStripButton FillGreenBtn;
        private System.Windows.Forms.ToolStripButton FillMoreColorBtn;
        private System.Windows.Forms.ToolStrip TopMenu;
        private System.Windows.Forms.ToolStripButton ClrBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton OpenBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton CursorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel TextShapes;
        private System.Windows.Forms.ToolStripButton LineBtn;
        private System.Windows.Forms.ToolStripButton PolyLineBtn;
        private System.Windows.Forms.ToolStripButton EllipseBtn;
        private System.Windows.Forms.ToolStripButton RectangleBtn;
        private System.Windows.Forms.ToolStripButton PolygonBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripComboBox LineType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel TextSizeLine;
        private System.Windows.Forms.ToolStripTextBox LineSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton PrevArrowBtn;
        private System.Windows.Forms.ToolStripButton NextArrowBtn;
        private System.Windows.Forms.TextBox DotX;
        private System.Windows.Forms.TextBox DotY;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuProject;
        private System.Windows.Forms.ToolStripMenuItem OpenProject;
        private System.Windows.Forms.ToolStripMenuItem SaveProject;
        private System.Windows.Forms.ToolStripMenuItem SaveAsProject;
        private System.Windows.Forms.ToolStripMenuItem JpgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BmpToolStripMenuItem;
    }
}


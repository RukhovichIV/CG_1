namespace CG_1
{
    partial class mainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pointFilterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionButton = new System.Windows.Forms.ToolStripMenuItem();
            this.grayWorldButton = new System.Windows.Forms.ToolStripMenuItem();
            this.perfectReflectorButton = new System.Windows.Forms.ToolStripMenuItem();
            this.linearStretchingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.glassButton = new System.Windows.Forms.ToolStripMenuItem();
            this.medianButton = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixFiltersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.blurButton = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianButton = new System.Windows.Forms.ToolStripMenuItem();
            this.stampingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.glowingEdgesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.математическаяМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationButton = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionButton = new System.Windows.Forms.ToolStripMenuItem();
            this.closingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.morphGradButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.chooseStructElementButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.filtersButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1304, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.chooseStructElementButton,
            this.saveButton});
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(48, 20);
            this.fileButton.Text = "Файл";
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(244, 22);
            this.openButton.Text = "Открыть";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // filtersButton
            // 
            this.filtersButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointFilterButton,
            this.matrixFiltersButton,
            this.математическаяМорфологияToolStripMenuItem});
            this.filtersButton.Name = "filtersButton";
            this.filtersButton.Size = new System.Drawing.Size(69, 20);
            this.filtersButton.Text = "Фильтры";
            // 
            // pointFilterButton
            // 
            this.pointFilterButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionButton,
            this.grayWorldButton,
            this.perfectReflectorButton,
            this.linearStretchingButton,
            this.rotateButton,
            this.glassButton,
            this.medianButton});
            this.pointFilterButton.Name = "pointFilterButton";
            this.pointFilterButton.Size = new System.Drawing.Size(240, 22);
            this.pointFilterButton.Text = "Точечные";
            // 
            // inversionButton
            // 
            this.inversionButton.Name = "inversionButton";
            this.inversionButton.Size = new System.Drawing.Size(204, 22);
            this.inversionButton.Text = "Инверсия";
            this.inversionButton.Click += new System.EventHandler(this.inversionButton_Click);
            // 
            // grayWorldButton
            // 
            this.grayWorldButton.Name = "grayWorldButton";
            this.grayWorldButton.Size = new System.Drawing.Size(204, 22);
            this.grayWorldButton.Text = "Серый мир";
            this.grayWorldButton.Click += new System.EventHandler(this.grayWorldButton_Click);
            // 
            // perfectReflectorButton
            // 
            this.perfectReflectorButton.Name = "perfectReflectorButton";
            this.perfectReflectorButton.Size = new System.Drawing.Size(204, 22);
            this.perfectReflectorButton.Text = "Идеальный отражатель";
            this.perfectReflectorButton.Click += new System.EventHandler(this.perfectReflectorButton_Click);
            // 
            // linearStretchingButton
            // 
            this.linearStretchingButton.Name = "linearStretchingButton";
            this.linearStretchingButton.Size = new System.Drawing.Size(204, 22);
            this.linearStretchingButton.Text = "Линейная коррекция";
            this.linearStretchingButton.Click += new System.EventHandler(this.linearStretchingButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(204, 22);
            this.rotateButton.Text = "Поворот";
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // glassButton
            // 
            this.glassButton.Name = "glassButton";
            this.glassButton.Size = new System.Drawing.Size(204, 22);
            this.glassButton.Text = "Стекло";
            this.glassButton.Click += new System.EventHandler(this.glassButton_Click);
            // 
            // medianButton
            // 
            this.medianButton.Name = "medianButton";
            this.medianButton.Size = new System.Drawing.Size(204, 22);
            this.medianButton.Text = "Медианный фильтр";
            this.medianButton.Click += new System.EventHandler(this.medianButton_Click);
            // 
            // matrixFiltersButton
            // 
            this.matrixFiltersButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurButton,
            this.gaussianButton,
            this.stampingButton,
            this.glowingEdgesButton});
            this.matrixFiltersButton.Name = "matrixFiltersButton";
            this.matrixFiltersButton.Size = new System.Drawing.Size(240, 22);
            this.matrixFiltersButton.Text = "Матричные";
            // 
            // blurButton
            // 
            this.blurButton.Name = "blurButton";
            this.blurButton.Size = new System.Drawing.Size(184, 22);
            this.blurButton.Text = "Размытие";
            this.blurButton.Click += new System.EventHandler(this.blurButton_Click);
            // 
            // gaussianButton
            // 
            this.gaussianButton.Name = "gaussianButton";
            this.gaussianButton.Size = new System.Drawing.Size(184, 22);
            this.gaussianButton.Text = "Размытие по Гауссу";
            this.gaussianButton.Click += new System.EventHandler(this.gaussianButton_Click);
            // 
            // stampingButton
            // 
            this.stampingButton.Name = "stampingButton";
            this.stampingButton.Size = new System.Drawing.Size(184, 22);
            this.stampingButton.Text = "Тиснение";
            this.stampingButton.Click += new System.EventHandler(this.stampingButton_Click);
            // 
            // glowingEdgesButton
            // 
            this.glowingEdgesButton.Name = "glowingEdgesButton";
            this.glowingEdgesButton.Size = new System.Drawing.Size(184, 22);
            this.glowingEdgesButton.Text = "Светящиеся края";
            this.glowingEdgesButton.Click += new System.EventHandler(this.glowingEdgesButton_Click);
            // 
            // математическаяМорфологияToolStripMenuItem
            // 
            this.математическаяМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationButton,
            this.erosionButton,
            this.closingButton,
            this.openingButton,
            this.morphGradButton});
            this.математическаяМорфологияToolStripMenuItem.Name = "математическаяМорфологияToolStripMenuItem";
            this.математическаяМорфологияToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.математическаяМорфологияToolStripMenuItem.Text = "Математическая морфология";
            // 
            // dilationButton
            // 
            this.dilationButton.Enabled = false;
            this.dilationButton.Name = "dilationButton";
            this.dilationButton.Size = new System.Drawing.Size(232, 22);
            this.dilationButton.Text = "Наращивание";
            this.dilationButton.Click += new System.EventHandler(this.dilationButton_Click);
            // 
            // erosionButton
            // 
            this.erosionButton.Enabled = false;
            this.erosionButton.Name = "erosionButton";
            this.erosionButton.Size = new System.Drawing.Size(232, 22);
            this.erosionButton.Text = "Эрозия";
            this.erosionButton.Click += new System.EventHandler(this.erosionButton_Click);
            // 
            // closingButton
            // 
            this.closingButton.Enabled = false;
            this.closingButton.Name = "closingButton";
            this.closingButton.Size = new System.Drawing.Size(232, 22);
            this.closingButton.Text = "Замыкание";
            this.closingButton.Click += new System.EventHandler(this.closingButton_Click);
            // 
            // openingButton
            // 
            this.openingButton.Enabled = false;
            this.openingButton.Name = "openingButton";
            this.openingButton.Size = new System.Drawing.Size(232, 22);
            this.openingButton.Text = "Размыкание";
            this.openingButton.Click += new System.EventHandler(this.openingButton_Click);
            // 
            // morphGradButton
            // 
            this.morphGradButton.Enabled = false;
            this.morphGradButton.Name = "morphGradButton";
            this.morphGradButton.Size = new System.Drawing.Size(232, 22);
            this.morphGradButton.Text = "Морфологический градиент";
            this.morphGradButton.Click += new System.EventHandler(this.morphGradButton_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 753);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1199, 23);
            this.progressBar.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(1217, 753);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // chooseStructElementButton
            // 
            this.chooseStructElementButton.Name = "chooseStructElementButton";
            this.chooseStructElementButton.Size = new System.Drawing.Size(244, 22);
            this.chooseStructElementButton.Text = "Выбрать структурный элемент";
            this.chooseStructElementButton.Click += new System.EventHandler(this.chooseStructElementButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(244, 22);
            this.saveButton.Text = "Сохранить изображение";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 788);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem fileButton;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.ToolStripMenuItem filtersButton;
        private System.Windows.Forms.ToolStripMenuItem pointFilterButton;
        private System.Windows.Forms.ToolStripMenuItem inversionButton;
        private System.Windows.Forms.ToolStripMenuItem matrixFiltersButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolStripMenuItem blurButton;
        private System.Windows.Forms.ToolStripMenuItem gaussianButton;
        private System.Windows.Forms.ToolStripMenuItem grayWorldButton;
        private System.Windows.Forms.ToolStripMenuItem perfectReflectorButton;
        private System.Windows.Forms.ToolStripMenuItem linearStretchingButton;
        private System.Windows.Forms.ToolStripMenuItem stampingButton;
        private System.Windows.Forms.ToolStripMenuItem rotateButton;
        private System.Windows.Forms.ToolStripMenuItem glassButton;
        private System.Windows.Forms.ToolStripMenuItem glowingEdgesButton;
        private System.Windows.Forms.ToolStripMenuItem medianButton;
        private System.Windows.Forms.ToolStripMenuItem математическаяМорфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationButton;
        private System.Windows.Forms.ToolStripMenuItem erosionButton;
        private System.Windows.Forms.ToolStripMenuItem closingButton;
        private System.Windows.Forms.ToolStripMenuItem openingButton;
        private System.Windows.Forms.ToolStripMenuItem morphGradButton;
        private System.Windows.Forms.ToolStripMenuItem chooseStructElementButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
    }
}


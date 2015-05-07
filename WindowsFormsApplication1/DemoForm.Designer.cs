namespace WindowsFormsApplication1
{
    partial class DemoForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.screenBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkShowAreas = new System.Windows.Forms.CheckBox();
            this.checkDrawField = new System.Windows.Forms.CheckBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.turnCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.agentAddingBox = new System.Windows.Forms.TableLayoutPanel();
            this.agentSelectBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addAgentNumeric = new System.Windows.Forms.NumericUpDown();
            this.addAgentButton = new System.Windows.Forms.Button();
            this.agentsBox = new System.Windows.Forms.ListBox();
            this.deleteAgentButon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.limitLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.logBox = new System.Windows.Forms.ListBox();
            this.logLable = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.taskList = new System.Windows.Forms.CheckedListBox();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.timeUpdater = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.agentAddingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addAgentNumeric)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.80576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.19424F));
            this.tableLayoutPanel1.Controls.Add(this.screenBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.3138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.68619F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // screenBox
            // 
            this.screenBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenBox.Location = new System.Drawing.Point(4, 4);
            this.screenBox.Name = "screenBox";
            this.screenBox.Size = new System.Drawing.Size(354, 352);
            this.screenBox.TabIndex = 0;
            this.screenBox.TabStop = false;
            this.screenBox.Paint += new System.Windows.Forms.PaintEventHandler(this.screenBox_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.97701F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.02299F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.checkShowAreas, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkDrawField, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pauseButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 363);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.29358F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.70642F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(354, 112);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // checkShowAreas
            // 
            this.checkShowAreas.AutoSize = true;
            this.checkShowAreas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkShowAreas.Checked = true;
            this.checkShowAreas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShowAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkShowAreas.Location = new System.Drawing.Point(167, 6);
            this.checkShowAreas.Name = "checkShowAreas";
            this.checkShowAreas.Size = new System.Drawing.Size(181, 47);
            this.checkShowAreas.TabIndex = 4;
            this.checkShowAreas.Text = "Показать области видимости";
            this.checkShowAreas.UseVisualStyleBackColor = true;
            this.checkShowAreas.CheckedChanged += new System.EventHandler(this.checkShowAreas_CheckedChanged);
            // 
            // checkDrawField
            // 
            this.checkDrawField.AutoSize = true;
            this.checkDrawField.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkDrawField.Checked = true;
            this.checkDrawField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDrawField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkDrawField.Location = new System.Drawing.Point(167, 62);
            this.checkDrawField.Name = "checkDrawField";
            this.checkDrawField.Size = new System.Drawing.Size(181, 44);
            this.checkDrawField.TabIndex = 1;
            this.checkDrawField.Text = "Отрисовка";
            this.checkDrawField.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseButton.Location = new System.Drawing.Point(6, 62);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(152, 44);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Начать";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.07784F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.92216F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.timeLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.turnCountLabel, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(152, 47);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ходов сделано";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время работы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(95, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(54, 24);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "00:00,0";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turnCountLabel
            // 
            this.turnCountLabel.AutoSize = true;
            this.turnCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnCountLabel.Location = new System.Drawing.Point(95, 24);
            this.turnCountLabel.Name = "turnCountLabel";
            this.turnCountLabel.Size = new System.Drawing.Size(54, 23);
            this.turnCountLabel.TabIndex = 3;
            this.turnCountLabel.Text = "0";
            this.turnCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.2569F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.7431F));
            this.tableLayoutPanel4.Controls.Add(this.agentAddingBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.descriptionBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(365, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.84091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.15909F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(477, 352);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // agentAddingBox
            // 
            this.agentAddingBox.ColumnCount = 2;
            this.agentAddingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.33334F));
            this.agentAddingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.66667F));
            this.agentAddingBox.Controls.Add(this.agentSelectBox, 0, 1);
            this.agentAddingBox.Controls.Add(this.label1, 0, 0);
            this.agentAddingBox.Controls.Add(this.addAgentNumeric, 1, 1);
            this.agentAddingBox.Controls.Add(this.addAgentButton, 1, 2);
            this.agentAddingBox.Controls.Add(this.agentsBox, 0, 4);
            this.agentAddingBox.Controls.Add(this.deleteAgentButon, 1, 4);
            this.agentAddingBox.Controls.Add(this.label3, 0, 3);
            this.agentAddingBox.Controls.Add(this.limitLabel, 1, 0);
            this.agentAddingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentAddingBox.Location = new System.Drawing.Point(3, 3);
            this.agentAddingBox.Name = "agentAddingBox";
            this.agentAddingBox.RowCount = 5;
            this.agentAddingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.agentAddingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.5F));
            this.agentAddingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.agentAddingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.agentAddingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.agentAddingBox.Size = new System.Drawing.Size(228, 180);
            this.agentAddingBox.TabIndex = 2;
            // 
            // agentSelectBox
            // 
            this.agentSelectBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentSelectBox.FormattingEnabled = true;
            this.agentSelectBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.agentSelectBox.Location = new System.Drawing.Point(3, 30);
            this.agentSelectBox.Name = "agentSelectBox";
            this.agentSelectBox.Size = new System.Drawing.Size(142, 21);
            this.agentSelectBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Добавление агентов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addAgentNumeric
            // 
            this.addAgentNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAgentNumeric.Location = new System.Drawing.Point(151, 30);
            this.addAgentNumeric.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.addAgentNumeric.Name = "addAgentNumeric";
            this.addAgentNumeric.Size = new System.Drawing.Size(74, 20);
            this.addAgentNumeric.TabIndex = 0;
            // 
            // addAgentButton
            // 
            this.addAgentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addAgentButton.Location = new System.Drawing.Point(151, 60);
            this.addAgentButton.Name = "addAgentButton";
            this.addAgentButton.Size = new System.Drawing.Size(74, 19);
            this.addAgentButton.TabIndex = 7;
            this.addAgentButton.Text = "Добавить";
            this.addAgentButton.UseVisualStyleBackColor = true;
            this.addAgentButton.Click += new System.EventHandler(this.addAgentButton_Click_1);
            // 
            // agentsBox
            // 
            this.agentsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentsBox.FormattingEnabled = true;
            this.agentsBox.Location = new System.Drawing.Point(3, 127);
            this.agentsBox.Name = "agentsBox";
            this.agentsBox.Size = new System.Drawing.Size(142, 50);
            this.agentsBox.Sorted = true;
            this.agentsBox.TabIndex = 4;
            // 
            // deleteAgentButon
            // 
            this.deleteAgentButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteAgentButon.Location = new System.Drawing.Point(151, 127);
            this.deleteAgentButon.Name = "deleteAgentButon";
            this.deleteAgentButon.Size = new System.Drawing.Size(74, 23);
            this.deleteAgentButon.TabIndex = 3;
            this.deleteAgentButon.Text = "Удалить";
            this.deleteAgentButon.UseVisualStyleBackColor = true;
            this.deleteAgentButon.Click += new System.EventHandler(this.deleteAgentButon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список добавленных агентов";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // limitLabel
            // 
            this.limitLabel.AutoSize = true;
            this.limitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.limitLabel.Location = new System.Drawing.Point(151, 0);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(74, 27);
            this.limitLabel.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.logBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.logLable, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 189);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(228, 160);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(3, 24);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(222, 133);
            this.logBox.TabIndex = 8;
            // 
            // logLable
            // 
            this.logLable.AutoSize = true;
            this.logLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logLable.Location = new System.Drawing.Point(3, 0);
            this.logLable.Name = "logLable";
            this.logLable.Size = new System.Drawing.Size(222, 21);
            this.logLable.TabIndex = 7;
            this.logLable.Text = "Лог событий";
            this.logLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionBox
            // 
            this.descriptionBox.AutoSize = true;
            this.descriptionBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionBox.Location = new System.Drawing.Point(237, 0);
            this.descriptionBox.Name = "descriptionBox";
            this.tableLayoutPanel4.SetRowSpan(this.descriptionBox, 2);
            this.descriptionBox.Size = new System.Drawing.Size(237, 352);
            this.descriptionBox.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.taskList, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(365, 363);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.43011F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.56989F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(477, 112);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цели";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskList
            // 
            this.taskList.CausesValidation = false;
            this.taskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskList.FormattingEnabled = true;
            this.taskList.Location = new System.Drawing.Point(3, 25);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(471, 84);
            this.taskList.TabIndex = 9;
            // 
            // drawTimer
            // 
            this.drawTimer.Enabled = true;
            this.drawTimer.Interval = 50;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // timeUpdater
            // 
            this.timeUpdater.Enabled = true;
            this.timeUpdater.Tick += new System.EventHandler(this.timeUpdater_Tick);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DemoForm";
            this.Text = "SearchCraft";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.agentAddingBox.ResumeLayout(false);
            this.agentAddingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addAgentNumeric)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox screenBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkDrawField;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.CheckBox checkShowAreas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown addAgentNumeric;
        private System.Windows.Forms.TableLayoutPanel agentAddingBox;
        private System.Windows.Forms.ComboBox agentSelectBox;
        private System.Windows.Forms.ListBox agentsBox;
        private System.Windows.Forms.Button deleteAgentButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Label logLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox taskList;
        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.Timer timeUpdater;
        private System.Windows.Forms.Button addAgentButton;
        private System.Windows.Forms.Label limitLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label turnCountLabel;
        private System.Windows.Forms.Label descriptionBox;
    }
}


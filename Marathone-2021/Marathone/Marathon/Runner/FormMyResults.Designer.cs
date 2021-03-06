namespace Marathon.Runner
{
    partial class FormMyResults
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
            this.tableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelNameTag = new System.Windows.Forms.Label();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.tableLayoutPanelCenter = new System.Windows.Forms.TableLayoutPanel();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSponsoreTitle = new System.Windows.Forms.Label();
            this.labelSponsoreInfo = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanelAll.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAll
            // 
            this.tableLayoutPanelAll.ColumnCount = 1;
            this.tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAll.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanelAll.Controls.Add(this.labelEventTime, 0, 2);
            this.tableLayoutPanelAll.Controls.Add(this.tableLayoutPanelCenter, 0, 1);
            this.tableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAll.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanelAll.Name = "tableLayoutPanelAll";
            this.tableLayoutPanelAll.RowCount = 3;
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAll.Size = new System.Drawing.Size(779, 430);
            this.tableLayoutPanelAll.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.buttonBack, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonLogout, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNameTag, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(779, 64);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Silver;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(10, 5);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(73, 34);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Silver;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(632, 5);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(137, 34);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.TabStop = false;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // labelNameTag
            // 
            this.labelNameTag.AutoSize = true;
            this.labelNameTag.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNameTag.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNameTag.Location = new System.Drawing.Point(95, 10);
            this.labelNameTag.Margin = new System.Windows.Forms.Padding(2, 10, 10, 0);
            this.labelNameTag.Name = "labelNameTag";
            this.labelNameTag.Size = new System.Drawing.Size(250, 54);
            this.labelNameTag.TabIndex = 1;
            this.labelNameTag.Text = "MARATHON SKILLS 2021";
            this.labelNameTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEventTime
            // 
            this.labelEventTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEventTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEventTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelEventTime.Location = new System.Drawing.Point(0, 386);
            this.labelEventTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(779, 44);
            this.labelEventTime.TabIndex = 1;
            this.labelEventTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelCenter
            // 
            this.tableLayoutPanelCenter.ColumnCount = 2;
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.64307F));
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.35693F));
            this.tableLayoutPanelCenter.Controls.Add(this.labelAge, 1, 2);
            this.tableLayoutPanelCenter.Controls.Add(this.labelSponsoreTitle, 0, 0);
            this.tableLayoutPanelCenter.Controls.Add(this.labelSponsoreInfo, 0, 1);
            this.tableLayoutPanelCenter.Controls.Add(this.labelGender, 0, 2);
            this.tableLayoutPanelCenter.Controls.Add(this.listViewResults, 0, 3);
            this.tableLayoutPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCenter.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanelCenter.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
            this.tableLayoutPanelCenter.RowCount = 5;
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.86944F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.902077F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.792285F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.96143F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCenter.Size = new System.Drawing.Size(779, 322);
            this.tableLayoutPanelCenter.TabIndex = 2;
            // 
            // labelAge
            // 
            this.labelAge.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAge.Location = new System.Drawing.Point(304, 69);
            this.labelAge.Margin = new System.Windows.Forms.Padding(3);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(225, 25);
            this.labelAge.TabIndex = 11;
            this.labelAge.Text = "Возрастная категория: ";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSponsoreTitle
            // 
            this.labelSponsoreTitle.AutoSize = true;
            this.tableLayoutPanelCenter.SetColumnSpan(this.labelSponsoreTitle, 2);
            this.labelSponsoreTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSponsoreTitle.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreTitle.Location = new System.Drawing.Point(2, 2);
            this.labelSponsoreTitle.Margin = new System.Windows.Forms.Padding(2);
            this.labelSponsoreTitle.Name = "labelSponsoreTitle";
            this.labelSponsoreTitle.Size = new System.Drawing.Size(775, 34);
            this.labelSponsoreTitle.TabIndex = 7;
            this.labelSponsoreTitle.Text = "Мои результаты";
            this.labelSponsoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSponsoreInfo
            // 
            this.labelSponsoreInfo.AutoSize = true;
            this.tableLayoutPanelCenter.SetColumnSpan(this.labelSponsoreInfo, 2);
            this.labelSponsoreInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSponsoreInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreInfo.Location = new System.Drawing.Point(2, 40);
            this.labelSponsoreInfo.Margin = new System.Windows.Forms.Padding(2);
            this.labelSponsoreInfo.Name = "labelSponsoreInfo";
            this.labelSponsoreInfo.Size = new System.Drawing.Size(775, 24);
            this.labelSponsoreInfo.TabIndex = 8;
            this.labelSponsoreInfo.Text = "Это - список всех ваших прошлых результатов гонки для Marathon Skills.";
            this.labelSponsoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGender
            // 
            this.labelGender.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelGender.Location = new System.Drawing.Point(187, 69);
            this.labelGender.Margin = new System.Windows.Forms.Padding(3);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(111, 25);
            this.labelGender.TabIndex = 10;
            this.labelGender.Text = "Пол: ";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listViewResults
            // 
            this.listViewResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.tableLayoutPanelCenter.SetColumnSpan(this.listViewResults, 2);
            this.listViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResults.Font = new System.Drawing.Font("Consolas", 10F);
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(3, 100);
            this.listViewResults.MultiSelect = false;
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(773, 152);
            this.listViewResults.TabIndex = 13;
            this.listViewResults.TabStop = false;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Марафон";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дистанция";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Время";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Общее место";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Место в группе";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // FormMyResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 510);
            this.Controls.Add(this.tableLayoutPanelAll);
            this.MaximizeBox = false;
            this.Name = "FormMyResults";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Мои результаты";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.tableLayoutPanelAll.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanelCenter.ResumeLayout(false);
            this.tableLayoutPanelCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelNameTag;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenter;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSponsoreTitle;
        private System.Windows.Forms.Label labelSponsoreInfo;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
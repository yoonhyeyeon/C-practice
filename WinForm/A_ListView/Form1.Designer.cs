
namespace A_ListView
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.myListView = new System.Windows.Forms.ListView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sImageList = new System.Windows.Forms.RadioButton();
            this.ImageSize = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myListView
            // 
            this.myListView.HideSelection = false;
            this.myListView.Location = new System.Drawing.Point(47, 57);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(360, 191);
            this.myListView.TabIndex = 0;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.SelectedIndexChanged += new System.EventHandler(this.myListView_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(47, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "자세히";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(112, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "리스트";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // sImageList
            // 
            this.sImageList.AutoSize = true;
            this.sImageList.Location = new System.Drawing.Point(177, 25);
            this.sImageList.Name = "sImageList";
            this.sImageList.Size = new System.Drawing.Size(87, 16);
            this.sImageList.TabIndex = 3;
            this.sImageList.TabStop = true;
            this.sImageList.Text = "작은 아이콘";
            this.sImageList.UseVisualStyleBackColor = true;
            this.sImageList.CheckedChanged += new System.EventHandler(this.sImageList_CheckedChanged);
            // 
            // ImageSize
            // 
            this.ImageSize.AutoSize = true;
            this.ImageSize.Location = new System.Drawing.Point(270, 25);
            this.ImageSize.Name = "ImageSize";
            this.ImageSize.Size = new System.Drawing.Size(75, 16);
            this.ImageSize.TabIndex = 4;
            this.ImageSize.TabStop = true;
            this.ImageSize.Text = "큰 아이콘";
            this.ImageSize.UseVisualStyleBackColor = true;
            this.ImageSize.CheckedChanged += new System.EventHandler(this.ImageSize_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleted : ";
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(189, 261);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(218, 21);
            this.txtSelected.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 325);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageSize);
            this.Controls.Add(this.sImageList);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.myListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton sImageList;
        private System.Windows.Forms.RadioButton ImageSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelected;
    }
}


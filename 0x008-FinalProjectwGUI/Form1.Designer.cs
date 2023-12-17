namespace DesignPatternProject
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblArrayInfo;
        private System.Windows.Forms.ListBox listBoxSortedArray;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            // Create controls
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblArrayInfo = new System.Windows.Forms.Label();
            this.listBoxSortedArray = new System.Windows.Forms.ListBox();

            // Set properties for btnBubbleSort
            this.btnBubbleSort.Location = new System.Drawing.Point(50, 20);
            this.btnBubbleSort.Size = new System.Drawing.Size(100, 30);
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);

            // Set properties for btnMergeSort
            this.btnMergeSort.Location = new System.Drawing.Point(200, 20);
            this.btnMergeSort.Size = new System.Drawing.Size(100, 30);
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);

            // Set properties for btnQuickSort
            this.btnQuickSort.Location = new System.Drawing.Point(350, 20);
            this.btnQuickSort.Size = new System.Drawing.Size(100, 30);
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);

            // Set properties for btnReset
            this.btnReset.Location = new System.Drawing.Point(500, 20);
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // Set properties for lblArrayInfo
            this.lblArrayInfo.AutoSize = true;
            this.lblArrayInfo.Location = new System.Drawing.Point(50, 70);

            // Set properties for listBoxSortedArray
            this.listBoxSortedArray.FormattingEnabled = true;
            this.listBoxSortedArray.Location = new System.Drawing.Point(50, 100);
            this.listBoxSortedArray.Size = new System.Drawing.Size(200, 150);

            // Add controls to the form
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblArrayInfo);
            this.Controls.Add(this.listBoxSortedArray);
        }

        #endregion
    }
}

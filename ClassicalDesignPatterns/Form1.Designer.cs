namespace ClassicalDesignPatterns
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SingletonPattern = new System.Windows.Forms.Button();
            this.btn_PrototypePattern = new System.Windows.Forms.Button();
            this.btn_BuilderPattern = new System.Windows.Forms.Button();
            this.btn_AbstractFactoryPattern = new System.Windows.Forms.Button();
            this.btn_FactoryMethodPattern = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ProxyPattern = new System.Windows.Forms.Button();
            this.btn_FlyweightPattern = new System.Windows.Forms.Button();
            this.btn_FacadePattern = new System.Windows.Forms.Button();
            this.btn_DecoratorPattern = new System.Windows.Forms.Button();
            this.btn_CompositePattern = new System.Windows.Forms.Button();
            this.btn_BridgePattern = new System.Windows.Forms.Button();
            this.btn_AdapterPattern = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_VisitorPattern = new System.Windows.Forms.Button();
            this.btn_TemplateMethodPattern = new System.Windows.Forms.Button();
            this.btn_StrategyPattern = new System.Windows.Forms.Button();
            this.btn_StatePattern = new System.Windows.Forms.Button();
            this.btn_ObserverPattern = new System.Windows.Forms.Button();
            this.btn_MementoPattern = new System.Windows.Forms.Button();
            this.btn_MediatorPattern = new System.Windows.Forms.Button();
            this.btn_IteratorPattern = new System.Windows.Forms.Button();
            this.btn_InterpreterPattern = new System.Windows.Forms.Button();
            this.btn_CommandPattern = new System.Windows.Forms.Button();
            this.btn_ChainOfResponsibilityPattern = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PrototypePattern1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_PrototypePattern1);
            this.groupBox1.Controls.Add(this.btn_SingletonPattern);
            this.groupBox1.Controls.Add(this.btn_PrototypePattern);
            this.groupBox1.Controls.Add(this.btn_BuilderPattern);
            this.groupBox1.Controls.Add(this.btn_AbstractFactoryPattern);
            this.groupBox1.Controls.Add(this.btn_FactoryMethodPattern);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 748);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "创建型模式";
            // 
            // btn_SingletonPattern
            // 
            this.btn_SingletonPattern.Location = new System.Drawing.Point(22, 656);
            this.btn_SingletonPattern.Name = "btn_SingletonPattern";
            this.btn_SingletonPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_SingletonPattern.TabIndex = 4;
            this.btn_SingletonPattern.Text = "5、单例模式-SingletonPattern";
            this.btn_SingletonPattern.UseVisualStyleBackColor = true;
            this.btn_SingletonPattern.Click += new System.EventHandler(this.btn_SingletonPattern_Click);
            // 
            // btn_PrototypePattern
            // 
            this.btn_PrototypePattern.Location = new System.Drawing.Point(22, 457);
            this.btn_PrototypePattern.Name = "btn_PrototypePattern";
            this.btn_PrototypePattern.Size = new System.Drawing.Size(305, 58);
            this.btn_PrototypePattern.TabIndex = 3;
            this.btn_PrototypePattern.Text = "4、原型模式-PrototypePattern";
            this.btn_PrototypePattern.UseVisualStyleBackColor = true;
            this.btn_PrototypePattern.Click += new System.EventHandler(this.btn_PrototypePattern_Click);
            // 
            // btn_BuilderPattern
            // 
            this.btn_BuilderPattern.Location = new System.Drawing.Point(22, 342);
            this.btn_BuilderPattern.Name = "btn_BuilderPattern";
            this.btn_BuilderPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_BuilderPattern.TabIndex = 2;
            this.btn_BuilderPattern.Text = "3、建造者模式-BuilderPattern";
            this.btn_BuilderPattern.UseVisualStyleBackColor = true;
            this.btn_BuilderPattern.Click += new System.EventHandler(this.btn_BuilderPattern_Click);
            // 
            // btn_AbstractFactoryPattern
            // 
            this.btn_AbstractFactoryPattern.Location = new System.Drawing.Point(22, 185);
            this.btn_AbstractFactoryPattern.Name = "btn_AbstractFactoryPattern";
            this.btn_AbstractFactoryPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_AbstractFactoryPattern.TabIndex = 1;
            this.btn_AbstractFactoryPattern.Text = "2、抽象工厂模式-AbstractFactoryPattern";
            this.btn_AbstractFactoryPattern.UseVisualStyleBackColor = true;
            this.btn_AbstractFactoryPattern.Click += new System.EventHandler(this.btn_AbstractFactoryPattern_Click);
            // 
            // btn_FactoryMethodPattern
            // 
            this.btn_FactoryMethodPattern.Location = new System.Drawing.Point(22, 28);
            this.btn_FactoryMethodPattern.Name = "btn_FactoryMethodPattern";
            this.btn_FactoryMethodPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_FactoryMethodPattern.TabIndex = 0;
            this.btn_FactoryMethodPattern.Text = "1、工厂方法模式-FactoryMethodPattern";
            this.btn_FactoryMethodPattern.UseVisualStyleBackColor = true;
            this.btn_FactoryMethodPattern.Click += new System.EventHandler(this.btn_FactoryMethodPattern_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ProxyPattern);
            this.groupBox2.Controls.Add(this.btn_FlyweightPattern);
            this.groupBox2.Controls.Add(this.btn_FacadePattern);
            this.groupBox2.Controls.Add(this.btn_DecoratorPattern);
            this.groupBox2.Controls.Add(this.btn_CompositePattern);
            this.groupBox2.Controls.Add(this.btn_BridgePattern);
            this.groupBox2.Controls.Add(this.btn_AdapterPattern);
            this.groupBox2.Location = new System.Drawing.Point(389, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 748);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结构型模式";
            // 
            // btn_ProxyPattern
            // 
            this.btn_ProxyPattern.Location = new System.Drawing.Point(22, 658);
            this.btn_ProxyPattern.Name = "btn_ProxyPattern";
            this.btn_ProxyPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_ProxyPattern.TabIndex = 6;
            this.btn_ProxyPattern.Text = "12、代理模式-ProxyPattern";
            this.btn_ProxyPattern.UseVisualStyleBackColor = true;
            this.btn_ProxyPattern.Click += new System.EventHandler(this.btn_ProxyPattern_Click);
            // 
            // btn_FlyweightPattern
            // 
            this.btn_FlyweightPattern.Location = new System.Drawing.Point(22, 553);
            this.btn_FlyweightPattern.Name = "btn_FlyweightPattern";
            this.btn_FlyweightPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_FlyweightPattern.TabIndex = 5;
            this.btn_FlyweightPattern.Text = "11、享元模式-FlyweightPattern";
            this.btn_FlyweightPattern.UseVisualStyleBackColor = true;
            this.btn_FlyweightPattern.Click += new System.EventHandler(this.btn_FlyweightPattern_Click);
            // 
            // btn_FacadePattern
            // 
            this.btn_FacadePattern.Location = new System.Drawing.Point(22, 448);
            this.btn_FacadePattern.Name = "btn_FacadePattern";
            this.btn_FacadePattern.Size = new System.Drawing.Size(305, 58);
            this.btn_FacadePattern.TabIndex = 4;
            this.btn_FacadePattern.Text = "10、外观模式-FacadePattern";
            this.btn_FacadePattern.UseVisualStyleBackColor = true;
            this.btn_FacadePattern.Click += new System.EventHandler(this.btn_FacadePattern_Click);
            // 
            // btn_DecoratorPattern
            // 
            this.btn_DecoratorPattern.Location = new System.Drawing.Point(22, 343);
            this.btn_DecoratorPattern.Name = "btn_DecoratorPattern";
            this.btn_DecoratorPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_DecoratorPattern.TabIndex = 3;
            this.btn_DecoratorPattern.Text = "9、装饰器模式-DecoratorPattern";
            this.btn_DecoratorPattern.UseVisualStyleBackColor = true;
            this.btn_DecoratorPattern.Click += new System.EventHandler(this.btn_DecoratorPattern_Click);
            // 
            // btn_CompositePattern
            // 
            this.btn_CompositePattern.Location = new System.Drawing.Point(22, 238);
            this.btn_CompositePattern.Name = "btn_CompositePattern";
            this.btn_CompositePattern.Size = new System.Drawing.Size(305, 58);
            this.btn_CompositePattern.TabIndex = 2;
            this.btn_CompositePattern.Text = "8、组合模式-CompositePattern";
            this.btn_CompositePattern.UseVisualStyleBackColor = true;
            this.btn_CompositePattern.Click += new System.EventHandler(this.btn_CompositePattern_Click);
            // 
            // btn_BridgePattern
            // 
            this.btn_BridgePattern.Location = new System.Drawing.Point(22, 133);
            this.btn_BridgePattern.Name = "btn_BridgePattern";
            this.btn_BridgePattern.Size = new System.Drawing.Size(305, 58);
            this.btn_BridgePattern.TabIndex = 1;
            this.btn_BridgePattern.Text = "7、桥接模式-BridgePattern";
            this.btn_BridgePattern.UseVisualStyleBackColor = true;
            this.btn_BridgePattern.Click += new System.EventHandler(this.btn_BridgePattern_Click);
            // 
            // btn_AdapterPattern
            // 
            this.btn_AdapterPattern.Location = new System.Drawing.Point(22, 28);
            this.btn_AdapterPattern.Name = "btn_AdapterPattern";
            this.btn_AdapterPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_AdapterPattern.TabIndex = 0;
            this.btn_AdapterPattern.Text = "6、适配器模式-AdapterPattern";
            this.btn_AdapterPattern.UseVisualStyleBackColor = true;
            this.btn_AdapterPattern.Click += new System.EventHandler(this.btn_AdapterPattern_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_VisitorPattern);
            this.groupBox3.Controls.Add(this.btn_TemplateMethodPattern);
            this.groupBox3.Controls.Add(this.btn_StrategyPattern);
            this.groupBox3.Controls.Add(this.btn_StatePattern);
            this.groupBox3.Controls.Add(this.btn_ObserverPattern);
            this.groupBox3.Controls.Add(this.btn_MementoPattern);
            this.groupBox3.Controls.Add(this.btn_MediatorPattern);
            this.groupBox3.Controls.Add(this.btn_IteratorPattern);
            this.groupBox3.Controls.Add(this.btn_InterpreterPattern);
            this.groupBox3.Controls.Add(this.btn_CommandPattern);
            this.groupBox3.Controls.Add(this.btn_ChainOfResponsibilityPattern);
            this.groupBox3.Location = new System.Drawing.Point(766, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 748);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "行为型模式";
            // 
            // btn_VisitorPattern
            // 
            this.btn_VisitorPattern.Location = new System.Drawing.Point(22, 658);
            this.btn_VisitorPattern.Name = "btn_VisitorPattern";
            this.btn_VisitorPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_VisitorPattern.TabIndex = 10;
            this.btn_VisitorPattern.Text = "23、访问者模式-VisitorPattern";
            this.btn_VisitorPattern.UseVisualStyleBackColor = true;
            this.btn_VisitorPattern.Click += new System.EventHandler(this.btn_VisitorPattern_Click);
            // 
            // btn_TemplateMethodPattern
            // 
            this.btn_TemplateMethodPattern.Location = new System.Drawing.Point(22, 595);
            this.btn_TemplateMethodPattern.Name = "btn_TemplateMethodPattern";
            this.btn_TemplateMethodPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_TemplateMethodPattern.TabIndex = 9;
            this.btn_TemplateMethodPattern.Text = "22、模板方法模式-TemplateMethodPattern";
            this.btn_TemplateMethodPattern.UseVisualStyleBackColor = true;
            this.btn_TemplateMethodPattern.Click += new System.EventHandler(this.btn_TemplateMethodPattern_Click);
            // 
            // btn_StrategyPattern
            // 
            this.btn_StrategyPattern.Location = new System.Drawing.Point(22, 532);
            this.btn_StrategyPattern.Name = "btn_StrategyPattern";
            this.btn_StrategyPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_StrategyPattern.TabIndex = 8;
            this.btn_StrategyPattern.Text = "21、策略模式-StrategyPattern";
            this.btn_StrategyPattern.UseVisualStyleBackColor = true;
            this.btn_StrategyPattern.Click += new System.EventHandler(this.btn_StrategyPattern_Click);
            // 
            // btn_StatePattern
            // 
            this.btn_StatePattern.Location = new System.Drawing.Point(22, 469);
            this.btn_StatePattern.Name = "btn_StatePattern";
            this.btn_StatePattern.Size = new System.Drawing.Size(305, 58);
            this.btn_StatePattern.TabIndex = 7;
            this.btn_StatePattern.Text = "20、状态模式-StatePattern";
            this.btn_StatePattern.UseVisualStyleBackColor = true;
            this.btn_StatePattern.Click += new System.EventHandler(this.btn_StatePattern_Click);
            // 
            // btn_ObserverPattern
            // 
            this.btn_ObserverPattern.Location = new System.Drawing.Point(22, 406);
            this.btn_ObserverPattern.Name = "btn_ObserverPattern";
            this.btn_ObserverPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_ObserverPattern.TabIndex = 6;
            this.btn_ObserverPattern.Text = "19、观察者模式-ObserverPattern";
            this.btn_ObserverPattern.UseVisualStyleBackColor = true;
            this.btn_ObserverPattern.Click += new System.EventHandler(this.btn_ObserverPattern_Click);
            // 
            // btn_MementoPattern
            // 
            this.btn_MementoPattern.Location = new System.Drawing.Point(22, 343);
            this.btn_MementoPattern.Name = "btn_MementoPattern";
            this.btn_MementoPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_MementoPattern.TabIndex = 5;
            this.btn_MementoPattern.Text = "18、备忘录模式-MementoPattern";
            this.btn_MementoPattern.UseVisualStyleBackColor = true;
            this.btn_MementoPattern.Click += new System.EventHandler(this.btn_MementoPattern_Click);
            // 
            // btn_MediatorPattern
            // 
            this.btn_MediatorPattern.Location = new System.Drawing.Point(22, 280);
            this.btn_MediatorPattern.Name = "btn_MediatorPattern";
            this.btn_MediatorPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_MediatorPattern.TabIndex = 4;
            this.btn_MediatorPattern.Text = "17、中介者模式-MediatorPattern";
            this.btn_MediatorPattern.UseVisualStyleBackColor = true;
            this.btn_MediatorPattern.Click += new System.EventHandler(this.btn_MediatorPattern_Click);
            // 
            // btn_IteratorPattern
            // 
            this.btn_IteratorPattern.Location = new System.Drawing.Point(22, 217);
            this.btn_IteratorPattern.Name = "btn_IteratorPattern";
            this.btn_IteratorPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_IteratorPattern.TabIndex = 3;
            this.btn_IteratorPattern.Text = "16、迭代器模式-IteratorPattern";
            this.btn_IteratorPattern.UseVisualStyleBackColor = true;
            this.btn_IteratorPattern.Click += new System.EventHandler(this.btn_IteratorPattern_Click);
            // 
            // btn_InterpreterPattern
            // 
            this.btn_InterpreterPattern.Location = new System.Drawing.Point(22, 154);
            this.btn_InterpreterPattern.Name = "btn_InterpreterPattern";
            this.btn_InterpreterPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_InterpreterPattern.TabIndex = 2;
            this.btn_InterpreterPattern.Text = "15、解释器模式-InterpreterPattern";
            this.btn_InterpreterPattern.UseVisualStyleBackColor = true;
            this.btn_InterpreterPattern.Click += new System.EventHandler(this.btn_InterpreterPattern_Click);
            // 
            // btn_CommandPattern
            // 
            this.btn_CommandPattern.Location = new System.Drawing.Point(22, 91);
            this.btn_CommandPattern.Name = "btn_CommandPattern";
            this.btn_CommandPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_CommandPattern.TabIndex = 1;
            this.btn_CommandPattern.Text = "14、命令模式-CommandPattern";
            this.btn_CommandPattern.UseVisualStyleBackColor = true;
            this.btn_CommandPattern.Click += new System.EventHandler(this.btn_CommandPattern_Click);
            // 
            // btn_ChainOfResponsibilityPattern
            // 
            this.btn_ChainOfResponsibilityPattern.Location = new System.Drawing.Point(22, 28);
            this.btn_ChainOfResponsibilityPattern.Name = "btn_ChainOfResponsibilityPattern";
            this.btn_ChainOfResponsibilityPattern.Size = new System.Drawing.Size(305, 58);
            this.btn_ChainOfResponsibilityPattern.TabIndex = 0;
            this.btn_ChainOfResponsibilityPattern.Text = "13、责任链模式-ChainOfResponsibilityPattern";
            this.btn_ChainOfResponsibilityPattern.UseVisualStyleBackColor = true;
            this.btn_ChainOfResponsibilityPattern.Click += new System.EventHandler(this.btn_ChainOfResponsibilityPattern_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1193, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 713);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1193, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "调试信息窗口";
            // 
            // btn_PrototypePattern1
            // 
            this.btn_PrototypePattern1.Location = new System.Drawing.Point(22, 553);
            this.btn_PrototypePattern1.Name = "btn_PrototypePattern1";
            this.btn_PrototypePattern1.Size = new System.Drawing.Size(305, 58);
            this.btn_PrototypePattern1.TabIndex = 5;
            this.btn_PrototypePattern1.Text = "4-1、原型模式-PrototypePattern";
            this.btn_PrototypePattern1.UseVisualStyleBackColor = true;
            this.btn_PrototypePattern1.Click += new System.EventHandler(this.btn_PrototypePattern1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 810);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SingletonPattern;
        private System.Windows.Forms.Button btn_PrototypePattern;
        private System.Windows.Forms.Button btn_BuilderPattern;
        private System.Windows.Forms.Button btn_AbstractFactoryPattern;
        private System.Windows.Forms.Button btn_FactoryMethodPattern;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ProxyPattern;
        private System.Windows.Forms.Button btn_FlyweightPattern;
        private System.Windows.Forms.Button btn_FacadePattern;
        private System.Windows.Forms.Button btn_DecoratorPattern;
        private System.Windows.Forms.Button btn_CompositePattern;
        private System.Windows.Forms.Button btn_BridgePattern;
        private System.Windows.Forms.Button btn_AdapterPattern;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_VisitorPattern;
        private System.Windows.Forms.Button btn_TemplateMethodPattern;
        private System.Windows.Forms.Button btn_StrategyPattern;
        private System.Windows.Forms.Button btn_StatePattern;
        private System.Windows.Forms.Button btn_ObserverPattern;
        private System.Windows.Forms.Button btn_MementoPattern;
        private System.Windows.Forms.Button btn_MediatorPattern;
        private System.Windows.Forms.Button btn_IteratorPattern;
        private System.Windows.Forms.Button btn_InterpreterPattern;
        private System.Windows.Forms.Button btn_CommandPattern;
        private System.Windows.Forms.Button btn_ChainOfResponsibilityPattern;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrototypePattern1;
    }
}


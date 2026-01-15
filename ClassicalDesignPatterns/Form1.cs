using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//23个设计模式类库引用
using P1_FactoryMethodLibrary;
using P2_AbstractFactoryLibrary;
using P3_BuilderLibrary;
using P4_PrototypeLibrary;
using P5_SingletonLibrary;
using P6_AdapterLibrary;
using P7_BridgeLibrary;
using P8_CompositeLibrary;
using P9_DecoratorLibrary;
using P10_FacadeLibrary;
using P11_FlyweightLibrary;
using P12_ProxyLibrary;
using P13_ChainOfResponsibilityLibrary;
using P14_CommandLibrary;
using P15_InterpreterLibrary;
using P16_IteratorLibrary;
using P17_MediatorLibrary;
using P18_MementoLibrary;
using P19_ObserverLibrary;
using P20_StateLibrary;
using P21_StrategyLibrary;
using P22_TemplateMethodLibrary;
using P23_VisitorLibrary;
using P1_FactoryMethodLibrary.FinalProduction;
using P2_AbstractFactoryLibrary.ProductionFactoryInterface;
using P2_AbstractFactoryLibrary.SpecificProductionFactory;
using P8_CompositeLibrary.ProductionModuleBase;
using P8_CompositeLibrary.SpecificModuleType;
using P19_ObserverLibrary.Observer;
using P19_ObserverLibrary.SpecificObservee;
using P19_ObserverLibrary.SpecificObserver;
using P14_CommandLibrary.SpecificCommand;
using P4_PrototypeLibrary.ProductionModule;
using P4_1_PrototypeLibrary.SpecificPrototype.EmpPrototype;
using P4_1_PrototypeLibrary.PrototypeInterface;
using P4_1_PrototypeLibrary;
using P13_ChainOfResponsibilityLibrary.SpecificHandler;
using P16_IteratorLibrary.Aggregation;
using P16_IteratorLibrary.BaseDevice;
using P16_IteratorLibrary.BaseInterface;
using P17_MediatorLibrary.AbstractMediator;
using P17_MediatorLibrary.SpecificDevice;
using P22_TemplateMethodLibrary.SpecificSonTemplate;
using P23_VisitorLibrary.SpecificDevices;
using P23_VisitorLibrary.SpecificVisitor;


namespace ClassicalDesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //增加一处修改，以便测试新的gitignore功能
        }
        //1、工厂方法模式
        private void btn_FactoryMethodPattern_Click(object sender, EventArgs e)
        {
            //使用工厂方法创建不同类型的电脑过程
            //1、工厂创建方法的入参决定了创建哪种类型的电脑
            //2、工厂创建方法内部分流封装了各个类型电脑的创建细节
            //3、工厂创建方法中的目标电脑是包含了各个部件的综合配方(可能和创建者模式中的指挥者有点类似)
            P1_FactoryMethodLibrary.FinalProduction.Computer gamePC = ComputerFactory.Create(ComputerType.Game);
            P1_FactoryMethodLibrary.FinalProduction.Computer officePC = ComputerFactory.Create(ComputerType.Office);

            //展示创建结果
            gamePC.ShowConfig();
            officePC.ShowConfig();
        }
        //2、抽象工厂模式
        private void btn_AbstractFactoryPattern_Click(object sender, EventArgs e)
        {
            //使用抽象工厂创建不同类型的电脑过程
            //1、具体工厂类的实例决定了创建哪种类型的电脑
            IComputerFactory gameFactory = new GameComputerFactory();
            IComputerFactory officeFactory = new OfficeComputerFactory();
            //2、电脑组装器使用具体工厂类实例来创建各个部件并组装成整机，简单工厂中的分支被抽象工厂的多态性取代
            //3、而ComputerAssembler.Build方法和简单工厂中的Create方法其实是类似的，都是起到一个组装配方的作用（主要是组装时机），
            //简单工厂中的Create方法是直接给最终产品部件属性赋值，而ComputerAssembler.Build是调用接口方法给最终产品部件属性赋值
            P2_AbstractFactoryLibrary.FinalProduction.Computer gamePC = ComputerAssembler.Build(gameFactory);
            P2_AbstractFactoryLibrary.FinalProduction.Computer officePC = ComputerAssembler.Build(officeFactory);

            //展示创建结果
            gamePC.ShowConfig();
            officePC.ShowConfig();
        }
        //3、建造者模式
        private void btn_BuilderPattern_Click(object sender, EventArgs e)
        {

        }
        //4、原型模式(使用ICloneable接口实现和BinaryFormatter序列化深拷贝,有风险)
        private void btn_PrototypePattern_Click(object sender, EventArgs e)
        {
            // 1. 创建原型对象：游戏电脑
            P4_PrototypeLibrary.FinalProduction.Computer gamingPC = new P4_PrototypeLibrary.FinalProduction.Computer
            {
                Cpu = new P4_PrototypeLibrary.ProductionModule.CPU { Model = "Intel i9-13900K" },
                Memory = new P4_PrototypeLibrary.ProductionModule.Memory { Spec = "32GB DDR5 6400MHz" },
                HardDisk = new P4_PrototypeLibrary.ProductionModule.HardDisk { Capacity = "2TB NVMe SSD" },
                GraphicsCard = new GraphicsCard { Type = "NVIDIA RTX 4090" }
            };

            Console.WriteLine("===== 原型：游戏电脑 =====");
            gamingPC.ShowInfo();

            // 2. 克隆游戏电脑，得到新对象
            P4_PrototypeLibrary.FinalProduction.Computer officePC = (P4_PrototypeLibrary.FinalProduction.Computer)gamingPC.Clone();

            // 3. 修改克隆对象的部件，适配办公需求
            officePC.Cpu.Model = "Intel i5-12400";
            officePC.Memory.Spec = "16GB DDR4 3200MHz";
            officePC.GraphicsCard.Type = "Intel UHD 730 核显";

            Console.WriteLine("\n===== 克隆修改后：办公电脑 =====");
            officePC.ShowInfo();

            // 验证深拷贝：修改办公电脑不影响原型
            Console.WriteLine("\n===== 验证原型未被修改 =====");
            gamingPC.ShowInfo();

        }
        //4-1、原型模式变体1(使用泛型确保类型安全和递归克隆-比上面更安全)
        private void btn_PrototypePattern1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=== 原型模式示例调用 ===");

            // ===========================================
            // 示例1：基本克隆调用
            // ===========================================
            Console.WriteLine("\n1. 基本克隆示例：");

            // 创建原始员工
            var originalEmployee = new Employee
            {
                Name = "张三",
                Age = 30,
                Department = new Department
                {
                    Name = "技术部",
                    Manager = "李经理"
                }
            };

            originalEmployee.Skills.AddRange(new[]
            {
                new Skill { Name = "C#", Level = 5 },
                new Skill { Name = "ASP.NET", Level = 4 }
            });

            Console.WriteLine("原始员工信息：");
            originalEmployee.DisplayInfo();

            // 克隆员工
            var clonedEmployee = originalEmployee.Clone();
            clonedEmployee.Name = "张三克隆版";
            clonedEmployee.Age = 31;
            clonedEmployee.Skills[0].Level = 3; // 修改技能等级

            Console.WriteLine("克隆并修改后的员工信息：");
            clonedEmployee.DisplayInfo();

            Console.WriteLine("原始员工信息（应保持不变）：");
            originalEmployee.DisplayInfo();

            // ===========================================
            // 示例2：使用原型注册器
            // ===========================================
            Console.WriteLine("\n2. 原型注册器示例：");

            var registry = new PrototypeRegistry();

            // 创建并注册原型
            var defaultEmployee = new Employee
            {
                Name = "默认员工",
                Age = 25,
                Department = new Department
                {
                    Name = "人力资源部",
                    Manager = "王经理"
                }
            };
            defaultEmployee.Skills.Add(new Skill { Name = "沟通", Level = 4 });

            // 注册时需要进行类型转换
            registry.Register("DefaultEmployee", defaultEmployee as IPrototype<object>);

            // 注册另一个原型
            var managerEmployee = new Employee
            {
                Name = "默认经理",
                Age = 35,
                Department = new Department
                {
                    Name = "管理部门",
                    Manager = "刘总"
                }
            };
            managerEmployee.Skills.AddRange(new[]
            {
                new Skill { Name = "管理", Level = 5 },
                new Skill { Name = "领导力", Level = 4 }
            });

            registry.Register("ManagerEmployee", managerEmployee as IPrototype<object>);

            // 从注册器中获取克隆
            Console.WriteLine("从注册器获取'DefaultEmployee'克隆：");
            var clonedFromRegistry1 = registry.GetClone<Employee>("DefaultEmployee");
            clonedFromRegistry1.Name = "新员工1号";
            clonedFromRegistry1.DisplayInfo();

            Console.WriteLine("从注册器获取'ManagerEmployee'克隆：");
            var clonedFromRegistry2 = registry.GetClone<Employee>("ManagerEmployee");
            clonedFromRegistry2.Name = "新经理1号";
            clonedFromRegistry2.DisplayInfo();
        }
        //5、单例模式
        private void btn_SingletonPattern_Click(object sender, EventArgs e)
        {
            // 模块1 访问串口
            var portManager1 = SerialPortManager.Instance;
            portManager1.OpenPort();
            portManager1.SendCommand(new byte[] { 0x01, 0x03, 0x00, 0x00, 0x00, 0x01 });

            // 模块2 访问串口（和模块1是同一个实例）
            var portManager2 = SerialPortManager.Instance;
            Console.WriteLine($"两个实例是否相同：{ReferenceEquals(portManager1, portManager2)}"); // 输出 True

            // 关闭串口
            portManager2.ClosePort();
        }
        //6、适配器模式
        private void btn_AdapterPattern_Click(object sender, EventArgs e)
        {
            // 1. 创建旧传感器实例
            SerialTemperatureSensor oldSensor = new SerialTemperatureSensor();
            // 2. 创建适配器，包装旧传感器
            ITemperatureSensor sensor = new TemperatureSensorAdapter(oldSensor);
            // 3. 上位机直接调用目标接口，无需关心底层格式
            float temp = sensor.GetTemperature();
            Console.WriteLine($"上位机读取温度：{temp} °C");
        }
        //7、桥接模式
        private void btn_BridgePattern_Click(object sender, EventArgs e)
        {
            // 1. Modbus设备 + 串口通信
            P7_BridgeLibrary.IndustrialDevice modbusSerial = new ModbusDevice(new SerialCommunication());
            modbusSerial.ExecuteOperation("读取线圈状态");

            // 2. Modbus设备 + TCP通信
            P7_BridgeLibrary.IndustrialDevice modbusTcp = new ModbusDevice(new TcpCommunication());
            modbusTcp.ExecuteOperation("写入寄存器数值");

            // 3. Profinet设备 + TCP通信
            P7_BridgeLibrary.IndustrialDevice profinetTcp = new ProfinetDevice(new TcpCommunication());
            profinetTcp.ExecuteOperation("设备参数配置");
        }
        //8、组合模式
        private void btn_CompositePattern_Click(object sender, EventArgs e)
        {
            // 1. 创建单个设备（PLC/传感器/机械臂）
            P8_CompositeLibrary.ProductionModuleBase.IndustrialDevice plc1 = new SingleDevice("主控制PLC", "PLC-001");
            P8_CompositeLibrary.ProductionModuleBase.IndustrialDevice sensor1 = new SingleDevice("温度传感器", "SENSOR-001");
            P8_CompositeLibrary.ProductionModuleBase.IndustrialDevice sensor2 = new SingleDevice("压力传感器", "SENSOR-002");
            P8_CompositeLibrary.ProductionModuleBase.IndustrialDevice robot1 = new SingleDevice("装配机械臂", "ROBOT-001");

            // 2. 创建工位设备组（包含PLC+传感器+机械臂）
            DeviceGroup workStation1 = new DeviceGroup("一号装配工位", "STATION-001");
            workStation1.AddDevice(plc1);
            workStation1.AddDevice(sensor1);
            workStation1.AddDevice(sensor2);
            workStation1.AddDevice(robot1);

            // 3. 创建生产线设备组（包含多个工位）
            DeviceGroup productLine = new DeviceGroup("汽车零部件生产线", "LINE-001");
            productLine.AddDevice(workStation1);

            // 4. 再添加一个二号工位到生产线
            DeviceGroup workStation2 = new DeviceGroup("二号检测工位", "STATION-002");
            workStation2.AddDevice(new SingleDevice("质检PLC", "PLC-002"));
            workStation2.AddDevice(new SingleDevice("视觉传感器", "SENSOR-003"));
            productLine.AddDevice(workStation2);

            Console.WriteLine("\n========================================");

            // 5. 统一调用：批量启动整条生产线（递归操作所有子设备）
            productLine.StartDevice();

            // 6. 统一调用：获取整条生产线的状态
            Console.WriteLine("===== 生产线整体状态 =====");
            Console.WriteLine(productLine.GetRunStatus());

            // 7. 统一调用：批量停止一号工位
            workStation1.StopDevice();

            // 8. 再次查看生产线状态
            Console.WriteLine("\n===== 一号工位停止后，生产线状态 =====");
            Console.WriteLine(productLine.GetRunStatus());

        }
        //9、装饰器模式
        private void btn_DecoratorPattern_Click(object sender, EventArgs e)
        {
            // 1. 基础串口通信（无任何附加功能）
            ISerialComm comm = new BaseSerialComm();
            Console.WriteLine($"=== {comm.GetCommDescription()} ===");
            comm.SendData(new byte[] { 0x01, 0x03, 0x00, 0x00, 0x00, 0x01 });
            comm.ReceiveData();
            Console.WriteLine();

            // 2. 给基础串口添加CRC校验功能（动态扩展，无需修改BaseSerialComm）
            comm = new CrcCheckDecorator(comm);
            Console.WriteLine($"=== {comm.GetCommDescription()} ===");
            comm.SendData(new byte[] { 0x01, 0x03, 0x00, 0x00, 0x00, 0x01 });
            comm.ReceiveData();
            Console.WriteLine();

            // 3. 再给带CRC的串口添加日志记录功能（继续动态扩展）
            comm = new LogDecorator(comm);
            Console.WriteLine($"=== {comm.GetCommDescription()} ===");
            comm.SendData(new byte[] { 0x01, 0x03, 0x00, 0x00, 0x00, 0x01 });
            comm.ReceiveData();
        }
        //10、外观模式
        private void btn_FacadePattern_Click(object sender, EventArgs e)
        {
            // 客户端只和外观类交互
            ComputerFacade computer = new ComputerFacade();
            computer.StartComputer();
        }
        //11、享元模式
        private void btn_FlyweightPattern_Click(object sender, EventArgs e)
        {
            LightIndicatorFactory factory = new LightIndicatorFactory();
            // 模拟10个设备，每个设备有运行/停止/故障3种指示灯
            string[] deviceIds = { "PLC01", "PLC02", "PLC03", "PLC04", "PLC05", "PLC06", "PLC07", "PLC08", "PLC09", "PLC10" };
            string[] positions = { "主电源", "运行状态", "故障报警" };

            foreach (var deviceId in deviceIds)
            {
                // 运行指示灯（绿色）- 共享实例
                ILightIndicator runLight = factory.GetIndicator("绿色", "运行");
                runLight.Display(deviceId, positions[1]);

                // 停止指示灯（灰色）- 共享实例
                ILightIndicator stopLight = factory.GetIndicator("灰色", "停止");
                stopLight.Display(deviceId, positions[0]);

                // 故障指示灯（红色）- 共享实例
                ILightIndicator faultLight = factory.GetIndicator("红色", "故障");
                faultLight.Display(deviceId, positions[2]);
            }

            Console.WriteLine($"\n===== 共创建共享指示灯实例数量：{factory.GetPoolCount()} =====");
        }
        //12、代理模式
        private void btn_ProxyPattern_Click(object sender, EventArgs e)
        {
            // 创建真实PLC对象
            IPLCControl realPLC = new RealPLC();

            // 1. 工程师角色：拥有读写权限
            Console.WriteLine("===== 工程师操作 =====");
            IPLCControl engineerProxy = new PLCProxy(realPLC, "工程师");
            engineerProxy.WriteRegister(10, 200);
            Console.WriteLine($"读取数据：{engineerProxy.ReadRegister(10)}");

            // 2. 操作员角色：只有读取权限
            Console.WriteLine("\n===== 操作员操作 =====");
            IPLCControl operatorProxy = new PLCProxy(realPLC, "操作员");
            operatorProxy.WriteRegister(10, 300);
            Console.WriteLine($"读取数据：{operatorProxy.ReadRegister(10)}");

            // 3. 访客角色：无任何权限
            Console.WriteLine("\n===== 访客操作 =====");
            IPLCControl guestProxy = new PLCProxy(realPLC, "访客");
            guestProxy.WriteRegister(10, 400);
            Console.WriteLine($"读取数据：{guestProxy.ReadRegister(10)}");
        }
        //13、责任链模式
        private void btn_ChainOfResponsibilityPattern_Click(object sender, EventArgs e)
        {
            // 创建各个处理者
            var operatorHandler = new OperatorHandler();
            var foremanHandler = new ForemanHandler();
            var supervisorHandler = new SupervisorHandler();

            // 构建职责链：操作员 → 班长 → 主管
            operatorHandler.SetNextHandler(foremanHandler);
            foremanHandler.SetNextHandler(supervisorHandler);

            // 模拟不同级别的报警
            operatorHandler.HandleAlarm("普通", "温度略高（35℃）");
            operatorHandler.HandleAlarm("严重", "温度过高（50℃）");
            operatorHandler.HandleAlarm("紧急", "设备冒烟！");
            operatorHandler.HandleAlarm("未知", "传感器异常");
        }
        //14、命令模式
        private void btn_CommandPattern_Click(object sender, EventArgs e)
        {
            //***注意IndustrialDevice类在多个类库中都有定义，要看清楚对应模式的事件下是否正确使用了对那个类库的IndustrialDevice类
            // 初始化设备和调用者
            P14_CommandLibrary.CommandReceiver.IndustrialDevice plcDevice = new P14_CommandLibrary.CommandReceiver.IndustrialDevice("车间PLC设备");
            CommandInvoker buttonPanel = new CommandInvoker();

            Console.WriteLine("===== 初始状态 =====");
            plcDevice.ShowStatus();

            // 执行启动命令
            Console.WriteLine("\n===== 执行启动命令 =====");
            buttonPanel.SetCommand(new StartDeviceCommand(plcDevice));
            plcDevice.ShowStatus();

            // 执行调整速度命令
            Console.WriteLine("\n===== 执行调整速度命令 =====");
            buttonPanel.SetCommand(new SetSpeedCommand(plcDevice, 500));
            plcDevice.ShowStatus();

            // 撤销上一次命令
            Console.WriteLine("\n===== 撤销上一次操作 =====");
            buttonPanel.UndoLastCommand();
            plcDevice.ShowStatus();

            // 执行停止命令
            Console.WriteLine("\n===== 执行停止命令 =====");
            buttonPanel.SetCommand(new StopDeviceCommand(plcDevice));
            plcDevice.ShowStatus();

        }
        //15、解释器模式
        private void btn_InterpreterPattern_Click(object sender, EventArgs e)
        {

        }
        //16、迭代器模式
        private void btn_IteratorPattern_Click(object sender, EventArgs e)
        {
            // 1. 初始化PLC设备（数组存储）
            Device[] plcs = new Device[]
            {
            new Device("PLC-001", "PLC", "运行中"),
            new Device("PLC-002", "PLC", "待机"),
            new Device("PLC-003", "PLC", "故障")
            };
            IDeviceCollection plcCollection = new PlcCollection(plcs);

            // 2. 初始化传感器设备（链表存储）
            LinkedList<Device> sensors = new LinkedList<Device>();
            sensors.AddLast(new Device("Temp-01", "Sensor", "正常"));
            sensors.AddLast(new Device("Humid-01", "Sensor", "正常"));
            sensors.AddLast(new Device("Press-01", "Sensor", "异常"));
            IDeviceCollection sensorCollection = new SensorCollection(sensors);

            // 3. 统一遍历PLC集合
            Console.WriteLine("=== PLC设备列表 ===");
            TraverseDevices(plcCollection);

            // 4. 统一遍历传感器集合（无需关心内部存储方式）
            Console.WriteLine("\n=== 传感器列表 ===");
            TraverseDevices(sensorCollection);


            // 通用遍历方法（对客户端隐藏集合内部结构）
            void TraverseDevices(IDeviceCollection deviceCollection)
            {
                IDeviceIterator iterator = deviceCollection.CreateIterator();
                while (iterator.HasNext())
                {
                    Device device = iterator.Next();
                    Console.WriteLine($"名称：{device.Name}，类型：{device.Type}，状态：{device.Status}");
                }
            }
        }
        //17、中介者模式
        private void btn_MediatorPattern_Click(object sender, EventArgs e)
        {
            // 1. 创建中介者（设备协调器）
            DeviceMediator coordinator = new DeviceCoordinator();

            // 2. 创建设备并注册到中介者（自动注册）
            var sensor = new P17_MediatorLibrary.SpecificDevice.TemperatureSensor("Temp-Sensor-01", coordinator);
            var plc = new PlcController("PLC-001", coordinator);
            var alarm = new Alarm("Alarm-01", coordinator);

            // 3. 模拟传感器检测温度
            Console.WriteLine("=== 模拟温度检测 ===");
            sensor.DetectTemperature(45.2f); // 温度正常
            Console.WriteLine("\n--- 5分钟后 ---");
            sensor.DetectTemperature(58.7f); // 温度过高

            // 4. 模拟手动校准传感器（通过中介者转发指令）
            Console.WriteLine("\n=== 手动操作 ===");
            plc.Send("请校准温度传感器");
        }
        //18、备忘录模式
        private void btn_MementoPattern_Click(object sender, EventArgs e)
        {
            // 1. 创建配方对象（发起人）和配方管理器（管理者）
            RecipeOriginator recipe = new RecipeOriginator();
            RecipeCaretaker caretaker = new RecipeCaretaker();

            // 2. 设置配方1并保存
            recipe.Temp = 180;
            recipe.Pressure = 2.5;
            recipe.Speed = 1500;
            caretaker.AddMemento("配方A", recipe.SaveToMemento());

            // 3. 修改配方为配方2并保存
            recipe.Temp = 200;
            recipe.Pressure = 3.0;
            recipe.Speed = 1800;
            caretaker.AddMemento("配方B", recipe.SaveToMemento());

            // 4. 误操作修改配方参数
            Console.WriteLine("\n=== 误操作修改配方参数 ===");
            recipe.Temp = 100;
            recipe.Pressure = 1.0;
            recipe.Speed = 800;
            recipe.ShowRecipe();

            // 5. 恢复配方A
            Console.WriteLine("\n=== 恢复配方A ===");
            recipe.RestoreFromMemento(caretaker.GetMemento("配方A"));
            recipe.ShowRecipe();

            // 6. 切换到配方B
            Console.WriteLine("\n=== 切换到配方B ===");
            recipe.RestoreFromMemento(caretaker.GetMemento("配方B"));
            recipe.ShowRecipe();
        }
        //19、观察者模式
        private void btn_ObserverPattern_Click(object sender, EventArgs e)
        {
            // 创建被观察者：温度传感器
            P19_ObserverLibrary.SpecificObservee.TemperatureSensor sensor = new P19_ObserverLibrary.SpecificObservee.TemperatureSensor();

            // 创建观察者并订阅
            IObserver display = new TemperatureDisplay();
            IObserver alarm = new TemperatureAlarm();
            IObserver recorder = new TemperatureRecorder();

            sensor.RegisterObserver(display);
            sensor.RegisterObserver(alarm);
            sensor.RegisterObserver(recorder);

            // 模拟传感器多次采集数据
            Console.WriteLine("===== 传感器开始工作 =====");
            for (int i = 0; i < 3; i++)
            {
                sensor.CollectTemperature();
                System.Threading.Thread.Sleep(1000); // 模拟间隔1秒
                Console.WriteLine("------------------------");
            }

            // 取消某个观察者订阅
            sensor.RemoveObserver(alarm);
            Console.WriteLine("===== 取消报警模块订阅 =====");
            sensor.CollectTemperature();
        }
        //20、状态模式
        private void btn_StatePattern_Click(object sender, EventArgs e)
        {
            // 创建电机上下文（相当于上位机连接的电机设备）
            MotorContext motor = new MotorContext();

            Console.WriteLine("\n===== 操作1：启动电机 =====");
            motor.StartMotor();
            Console.WriteLine($"当前状态：{motor.GetCurrentState()}");

            Console.WriteLine("\n===== 操作2：再次启动电机 =====");
            motor.StartMotor();

            Console.WriteLine("\n===== 操作3：触发电机故障 =====");
            motor.TriggerFault();
            Console.WriteLine($"当前状态：{motor.GetCurrentState()}");

            Console.WriteLine("\n===== 操作4：故障状态下启动电机 =====");
            motor.StartMotor();

            Console.WriteLine("\n===== 操作5：故障状态下停止电机 =====");
            motor.StopMotor();
        }
        //21、策略模式
        private void btn_StrategyPattern_Click(object sender, EventArgs e)
        {
            // ===== 4. 客户端测试：模拟工控上位机切换不同控制算法 =====
            // 创建温度控制上下文
            TempControlContext controlContext = new TempControlContext();
            double targetTemp = 50.0;

            // 场景1：使用默认PID策略
            controlContext.Control(25.0, targetTemp);
            controlContext.Control(45.0, targetTemp);

            // 场景2：切换为模糊控制策略
            controlContext.SetStrategy(new FuzzyControlStrategy());
            controlContext.Control(30.0, targetTemp);

            // 场景3：切换为自适应控制策略
            controlContext.SetStrategy(new AdaptiveControlStrategy());
            controlContext.Control(48.0, targetTemp);
        }
        //22、模板方法模式
        private void btn_TemplateMethodPattern_Click(object sender, EventArgs e)
        {
            // 温度控制流程
            var tempControl = new TemperatureController("DB1.DBD0");
            tempControl.ControlProcess();

            // 压力控制流程
            var pressureControl = new PressureController("DB2.DBD0");
            pressureControl.ControlProcess();
        }
        //23、访问者模式
        private void btn_VisitorPattern_Click(object sender, EventArgs e)
        {
            // 1. 初始化设备集合
            var deviceCollection = new DeviceCollection();
            deviceCollection.AddDevice(new PlcDevice("PLC-001", "V2.1"));
            deviceCollection.AddDevice(new SensorDevice("TEMP-001", "温度"));
            deviceCollection.AddDevice(new SensorDevice("PRESS-001", "压力"));
            deviceCollection.AddDevice(new AlarmDevice("ALARM-001", true));
            deviceCollection.AddDevice(new AlarmDevice("ALARM-002", false));

            // 2. 执行设备自检（使用自检访问者）
            Console.WriteLine("============= 设备自检流程 =============");
            var selfCheckVisitor = new SelfCheckVisitor();
            deviceCollection.AcceptVisitor(selfCheckVisitor);

            // 3. 执行数据备份（使用备份访问者）
            Console.WriteLine("============= 数据备份流程 =============");
            var dataBackupVisitor = new DataBackupVisitor(@"D:\IndustrialBackup");
            deviceCollection.AcceptVisitor(dataBackupVisitor);
        }
    }
}

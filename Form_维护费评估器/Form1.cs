using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Form_维护费评估器
{

    public partial class Form1 : Form
    {
        //存放列表信息的文件路径
         string path ;
        //读取存放列表信息的文件的所有行
        string[] fileNews;
        public Form1()
        {
            InitializeComponent();

            //获取当前所在路径
            string path = System.Environment.CurrentDirectory;
            //组合新路径
            string newPath = System.IO.Path.Combine(path, "path.txt");
            //判断该文件是否存在
            bool IsExist = File.Exists(newPath);
            this.path = newPath;
            if (IsExist == false)
            {
   
               // using (File.Create(newPath)) ;
                 WriteTxt(newPath);


            }
            LoadText();
        }

        private void test(string newPath)
        {
            File.Create(newPath);
        }
        /// <summary>
        /// 文件写入
        /// </summary>
        private void WriteTxt(string newPath)
        {
            //创建文件
            FileStream ss = new FileStream(newPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            ss.Close();
            StreamWriter writeTxt = new StreamWriter(newPath);

            writeTxt.WriteLine("步兵");
            writeTxt.WriteLine("装甲车");
            writeTxt.WriteLine("大炮");
            writeTxt.WriteLine("坦克");
            writeTxt.WriteLine("火箭车");
            writeTxt.WriteLine("重坦克");
            writeTxt.WriteLine("驱逐舰");
            writeTxt.WriteLine("巡洋舰");
            writeTxt.WriteLine("战列舰");
            writeTxt.WriteLine("航母");
            writeTxt.WriteLine("新兵种1");
            writeTxt.WriteLine("新兵种2");
            writeTxt.WriteLine("新兵种3");
            writeTxt.WriteLine("新兵种4");
            writeTxt.WriteLine("新兵种5");
            writeTxt.WriteLine("新兵种6");
            writeTxt.WriteLine("新兵种7");
            writeTxt.WriteLine("新兵种8");
            writeTxt.WriteLine("新兵种9");
            writeTxt.WriteLine("新兵种10");
            writeTxt.Flush();
            writeTxt.Close();
        }

        //comboBox1.Items.Add(fileNews[0]);
        //comboBox1.Items.Add(fileNews[1]);
        //comboBox1.Items.Add(fileNews[2]);
        //comboBox1.Items.Add(fileNews[3]);
        //comboBox1.Items.Add(fileNews[4]);
        //comboBox1.Items.Add(fileNews[5]);
        //comboBox1.Items.Add(fileNews[6]);
        //comboBox1.Items.Add(fileNews[7]);
        //comboBox1.Items.Add(fileNews[8]);
        //comboBox1.Items.Add(fileNews[9]);
        //comboBox1.Items.Add(fileNews[10]);
        //comboBox1.Items.Add(fileNews[11]);
        //comboBox1.Items.Add(fileNews[12]);
        //comboBox1.Items.Add(fileNews[13]);
        //comboBox1.Items.Add(fileNews[14]);
        //comboBox1.Items.Add(fileNews[15]);
        //comboBox1.Items.Add(fileNews[16]);
        //comboBox1.Items.Add(fileNews[17]);
        //comboBox1.Items.Add(fileNews[18]);
        //comboBox1.Items.Add(fileNews[19]);
        private void LoadText()
        {
            fileNews = File.ReadAllLines(this.path);
            for (int i = 0; i < fileNews.Length; i++)
            {
                comboBox1.Items.Add(fileNews[i]);
            }
            label1_Infantry.Text = fileNews[0];
            label1_Panzer.Text = fileNews[1];
            label2_Artillery.Text = fileNews[2];
            label1_Tank.Text = fileNews[3];
            label2_Rocket.Text = fileNews[4];
            label3_HTank.Text = fileNews[5];
            label1_Destroyer.Text = fileNews[6];
            label2_Cruiser.Text = fileNews[7];
            label3_Battleship.Text = fileNews[8];
            label4_AircraftCarrier.Text = fileNews[9];
            label11.Text = fileNews[10];
            label12.Text = fileNews[11];
            label13.Text = fileNews[12];
            label14.Text = fileNews[13];
            label15.Text = fileNews[14];
            label16.Text = fileNews[15];
            label17.Text = fileNews[16];
            label18.Text = fileNews[17];
            label19.Text = fileNews[18];
            label20.Text = fileNews[19];


        }
        private void NewItem_刷新()
        {

            comboBox1.Items.Add(label1_Infantry.Text);
            comboBox1.Items.Add(label1_Panzer.Text);
            comboBox1.Items.Add(label2_Artillery.Text);
            comboBox1.Items.Add(label1_Tank.Text);
            comboBox1.Items.Add(label2_Rocket.Text);
            comboBox1.Items.Add(label3_HTank.Text);
            comboBox1.Items.Add(label1_Destroyer.Text);
            comboBox1.Items.Add(label2_Cruiser.Text);
            comboBox1.Items.Add(label3_Battleship.Text);
            comboBox1.Items.Add(label4_AircraftCarrier.Text);
            comboBox1.Items.Add(label11.Text);
            comboBox1.Items.Add(label12.Text);
            comboBox1.Items.Add(label13.Text);
            comboBox1.Items.Add(label14.Text);
            comboBox1.Items.Add(label15.Text);
            comboBox1.Items.Add(label16.Text);
            comboBox1.Items.Add(label17.Text);
            comboBox1.Items.Add(label18.Text);
            comboBox1.Items.Add(label19.Text);
            comboBox1.Items.Add(label20.Text);
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label1_Infantry.Text = textBox4_NewName.Text;
                    fileNews[0] = label1_Infantry.Text;
                    if (label1_Infantry.Text.Length > 4)
                    {
                        label1_Infantry.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 1:
                    label1_Panzer.Text = textBox4_NewName.Text;
                    fileNews[1] = label1_Panzer.Text;
                    if (label1_Panzer.Text.Length > 4)
                    {
                        label1_Panzer.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 2:
                    label2_Artillery.Text = textBox4_NewName.Text;
                    fileNews[2] = label2_Artillery.Text;
                    if (label2_Artillery.Text.Length > 4)
                    {
                        label2_Artillery.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 3:
                    label1_Tank.Text = textBox4_NewName.Text;
                    fileNews[3] = label1_Tank.Text;
                    if (label1_Tank.Text.Length > 4)
                    {
                        label1_Tank.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 4:
                    label2_Rocket.Text = textBox4_NewName.Text;
                    fileNews[4] = label2_Rocket.Text;
                    if (label2_Rocket.Text.Length > 4)
                    {
                        label2_Rocket.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 5:
                    label3_HTank.Text = textBox4_NewName.Text;
                    fileNews[5] = label3_HTank.Text;
                    if (label3_HTank.Text.Length > 4)
                    {
                        label3_HTank.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 6:
                    label1_Destroyer.Text = textBox4_NewName.Text;
                    fileNews[6] = label1_Destroyer.Text;
                    if (label1_Destroyer.Text.Length > 4)
                    {
                        label1_Destroyer.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 7:
                    label2_Cruiser.Text = textBox4_NewName.Text;
                    fileNews[7] = label2_Cruiser.Text;
                    if (label2_Cruiser.Text.Length > 4)
                    {
                        label2_Cruiser.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 8:
                    label3_Battleship.Text = textBox4_NewName.Text;
                    fileNews[8] = label3_Battleship.Text;
                    if (label3_Battleship.Text.Length > 4)
                    {
                        label3_Battleship.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 9:
                    label4_AircraftCarrier.Text = textBox4_NewName.Text;
                    fileNews[9] = label4_AircraftCarrier.Text;
                    if (label4_AircraftCarrier.Text.Length > 4)
                    {
                        label4_AircraftCarrier.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 10:
                    label11.Text = textBox4_NewName.Text;
                    fileNews[10] = label11.Text;
                    if (label11.Text.Length > 4)
                    {
                        label11.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 11:
                    label12.Text = textBox4_NewName.Text;
                    fileNews[11] = label12.Text;
                    if (label12.Text.Length > 4)
                    {
                        label12.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 12:
                    label13.Text = textBox4_NewName.Text;
                    fileNews[12] = label13.Text;
                    if (label13.Text.Length > 4)
                    {
                        label13.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 13:
                    label14.Text = textBox4_NewName.Text;
                    fileNews[13] = label14.Text;
                    if (label14.Text.Length > 4)
                    {
                        label14.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 14:
                    label15.Text = textBox4_NewName.Text;
                    fileNews[14] = label15.Text;
                    if (label15.Text.Length > 4)
                    {
                        label15.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 15:
                    label16.Text = textBox4_NewName.Text;
                    fileNews[15] = label16.Text;
                    if (label16.Text.Length > 4)
                    {
                        label16.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 16:
                    label17.Text = textBox4_NewName.Text;
                    fileNews[16] = label17.Text;
                    if (label17.Text.Length > 4)
                    {
                        label17.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 17:
                    label18.Text = textBox4_NewName.Text;
                    fileNews[17] = label18.Text;
                    if (label18.Text.Length > 4)
                    {
                        label18.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 18:
                    label19.Text = textBox4_NewName.Text;
                    fileNews[18] = label19.Text;
                    if (label19.Text.Length > 4)
                    {
                        label19.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
                case 19:
                    label20.Text = textBox4_NewName.Text;
                    fileNews[19] = label20.Text;
                    if (label20.Text.Length > 4)
                    {
                        label20.Font = new Font("宋体", 10, FontStyle.Bold);
                    }
                    break;
            }
            WriteTxt(fileNews);
            comboBox1.Items.Clear();
            comboBox1.Text = textBox4_NewName.Text;
            LoadText();



        }
        /// <summary>
        /// 同步文件中的列表信息
        /// </summary>
        /// <param name="fileNews"></param>
        private void WriteTxt(string[] fileNews)
        {
            
            StreamWriter writer = new StreamWriter(this.path);
            for (int i = 0; i < fileNews.Length; i++)
            {
                writer.WriteLine(fileNews[i],false);
            }
            writer.Flush();
            writer.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Infantry_Click(object sender, EventArgs e)
        {

        }

        private void button2_计算_Click(object sender, EventArgs e)
        {
            int total步兵金钱 = Convert.ToInt32(T_infantryMon.Text) * Convert.ToInt32(Cout步兵.Text);
            int total步兵工业 = Convert.ToInt32(T_infantryInd.Text) * Convert.ToInt32(Cout步兵.Text);
            int total装甲车金钱 = Convert.ToInt32(T_PanzerMon.Text) * Convert.ToInt32(Cout装甲车.Text);
            int total装甲车工业 = Convert.ToInt32(T_PanzerInd.Text) * Convert.ToInt32(Cout装甲车.Text);
            int total大炮金钱 = Convert.ToInt32(T_ArtilleryMon.Text) * Convert.ToInt32(Cout大炮.Text);
            int total大炮工业 = Convert.ToInt32(T_ArtilleryInd.Text) * Convert.ToInt32(Cout大炮.Text);
            int total坦克金钱 = Convert.ToInt32(T_TankMon.Text) * Convert.ToInt32(Cout坦克.Text);
            int total坦克工业 = Convert.ToInt32(T_TankInd.Text) * Convert.ToInt32(Cout坦克.Text);
            int total火箭车金钱 = Convert.ToInt32(T_RocketMon.Text) * Convert.ToInt32(Cout火箭车.Text);
            int total火箭车工业 = Convert.ToInt32(T_RocketInd.Text) * Convert.ToInt32(Cout火箭车.Text);
            int total重坦克金钱 = Convert.ToInt32(T_HtankMon.Text) * Convert.ToInt32(Cout重坦克.Text);
            int total重坦克工业 = Convert.ToInt32(T_HtankInd.Text) * Convert.ToInt32(Cout重坦克.Text);
            int total驱逐舰金钱 = Convert.ToInt32(T_驱逐Mon1.Text) * Convert.ToInt32(Cout驱逐舰.Text);
            int total驱逐舰工业 = Convert.ToInt32(T_驱逐Ind.Text) * Convert.ToInt32(Cout驱逐舰.Text);
            int total巡洋舰金钱 = Convert.ToInt32(T_巡洋Mon.Text) * Convert.ToInt32(Cout巡洋舰.Text);
            int total巡洋舰工业 = Convert.ToInt32(T_巡洋Ind.Text) * Convert.ToInt32(Cout巡洋舰.Text);
            int total战列舰金钱 = Convert.ToInt32(T_BattleshipMon.Text) * Convert.ToInt32(Cout战列舰.Text);
            int total战列舰工业 = Convert.ToInt32(T_战列Ind.Text) * Convert.ToInt32(Cout战列舰.Text);
            int total航母金钱 = Convert.ToInt32(T_航母Mon.Text) * Convert.ToInt32(Cout航母.Text);
            int total航母工业 = Convert.ToInt32(T_航母Ind.Text) * Convert.ToInt32(Cout航母.Text);
            int total_New1金钱 = Convert.ToInt32(T_New1Mon.Text) * Convert.ToInt32(CoutNew1.Text);
            int total_New1工业 = Convert.ToInt32(T_New1Ind.Text) * Convert.ToInt32(CoutNew1.Text);
            int total_New2金钱 = Convert.ToInt32(T_New2Mon.Text) * Convert.ToInt32(CoutNew2.Text);
            int total_New2工业 = Convert.ToInt32(T_New2Ind.Text) * Convert.ToInt32(CoutNew2.Text);
            int total_New3金钱 = Convert.ToInt32(T_New3Mon.Text) * Convert.ToInt32(CoutNew3.Text);
            int total_New3工业 = Convert.ToInt32(T_New3Ind.Text) * Convert.ToInt32(CoutNew3.Text);
            int total_New4金钱 = Convert.ToInt32(T_New4Mon.Text) * Convert.ToInt32(CoutNew4.Text);
            int total_New4工业 = Convert.ToInt32(T_New4Ind.Text) * Convert.ToInt32(CoutNew4.Text);
            int total_New5金钱 = Convert.ToInt32(T_New5Mon.Text) * Convert.ToInt32(CoutNew5.Text);
            int total_New5工业 = Convert.ToInt32(T_New5Ind.Text) * Convert.ToInt32(CoutNew5.Text);
            int total_New6金钱 = Convert.ToInt32(T_New6Mon.Text) * Convert.ToInt32(CoutNew6.Text);
            int total_New6工业 = Convert.ToInt32(T_New6Ind.Text) * Convert.ToInt32(CoutNew6.Text);
            int total_New7金钱 = Convert.ToInt32(T_New7Mon.Text) * Convert.ToInt32(CoutNew7.Text);
            int total_New7工业 = Convert.ToInt32(T_New7Ind.Text) * Convert.ToInt32(CoutNew7.Text);
            int total_New8金钱 = Convert.ToInt32(T_New8Mon.Text) * Convert.ToInt32(CoutNew8.Text);
            int total_New8工业 = Convert.ToInt32(T_New8Ind.Text) * Convert.ToInt32(CoutNew8.Text);
            int total_New9金钱 = Convert.ToInt32(T_New9Mon.Text) * Convert.ToInt32(CoutNew9.Text);
            int total_New9工业 = Convert.ToInt32(T_New9Ind.Text) * Convert.ToInt32(CoutNew9.Text);
            int total_New10金钱 = Convert.ToInt32(T_New10Mon.Text) * Convert.ToInt32(CoutNew10.Text);
            int total_New10工业 = Convert.ToInt32(T_New10Ind.Text) * Convert.ToInt32(CoutNew10.Text);



            MessageBox.Show("一回合的维护费金钱支出为："+(total步兵金钱+total装甲车金钱+total大炮金钱+total坦克金钱+total火箭车金钱+total重坦克金钱+total驱逐舰金钱+total巡洋舰金钱+total战列舰金钱+total航母金钱+total_New1金钱+total_New2金钱+total_New3金钱+total_New4金钱+total_New5金钱+total_New6金钱+total_New7金钱+total_New8金钱+total_New9金钱+total_New10金钱).ToString()
                             +"\n一回合的维护费工业支出为："+ (total步兵工业 + total装甲车工业 + total大炮工业 + total坦克工业 + total火箭车工业 + total重坦克工业 + total驱逐舰工业 + total巡洋舰工业 + total战列舰工业 + total航母工业 + total_New1工业 + total_New2工业 + total_New3工业 + total_New4工业 + total_New5工业 + total_New6工业 + total_New7工业 + total_New8工业 + total_New9工业 + total_New10工业).ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("程序立项时间：2021年2月6日\n程序完成时间：2021年2月7日21:40\n程序新版更新时间：2021年4月9日00:47\n作者：李德邻\n联系邮箱：2412395774@qq.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

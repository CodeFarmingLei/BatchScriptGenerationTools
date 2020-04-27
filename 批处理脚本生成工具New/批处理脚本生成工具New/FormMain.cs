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

namespace 批处理脚本生成工具New
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonCmd1_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.cmd1;

            //打开保存文件对话框
            saveFileDialogCmd.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonCmd2_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.cmd2;

            //打开保存文件对话框
            saveFileDialogCmd.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonCmd3_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.cmd3;

            //打开保存文件对话框
            saveFileDialogCmd.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonCmd4_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.cmd4;

            //打开保存文件对话框
            saveFileDialogCmd.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonCmd5_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.cmd5;

            //打开保存文件对话框
            saveFileDialogCmd.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonCmd6_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.cmd6;

            //打开保存文件对话框
            saveFileDialogCmd.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonVbs1_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.vbs1;

            //打开保存文件对话框
            saveFileDialogVbs.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonVbs2_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.vbs2;

            //打开保存文件对话框
            saveFileDialogVbs.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonVbs3_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.vbs3;

            //打开保存文件对话框
            saveFileDialogVbs.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonVbs4_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.vbs4;

            //打开保存文件对话框
            saveFileDialogVbs.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonVbs5_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.vbs5;

            //打开保存文件对话框
            saveFileDialogVbs.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonVbs6_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.vbs6;

            //打开保存文件对话框
            saveFileDialogVbs.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void buttonVbs7_Click(object sender, EventArgs e)
        {
            //读取资源文件的脚本数据保存到字符串
            string txtStr = Resource1.vbs7;

            //打开保存文件对话框
            saveFileDialogVbs.ShowDialog();

            try
            {
                string path = saveFileDialogCmd.FileName;    //存储保存文件路径

                //创建文件流
                FileStream mySaveFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(mySaveFs);
                mySw.Write(txtStr);  //将脚本文件数据写入文件

                mySw.Close();   //关闭写入器
                mySaveFs.Close();   //关闭文件流

                //结果反馈
                if (File.Exists(saveFileDialogCmd.FileName))
                {

                    MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("本次保存异常!! 可能原因如下~\n\n1.可能您关闭了保存文件对话框或者点击了取消按钮。\n2.程序脚本处理出错。\n\n如频出现此问题请联系开发者获取帮助", "本次保存异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //初始化提示信息
            //MessageBox.Show("欢迎使用本程序!!\n程序内包含一些破坏脚本,请慎重使用.\n本程序为学习交流使用\n作者：冬日晨曦","欢迎使用!!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}

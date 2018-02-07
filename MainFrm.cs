using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace BatteryStatus
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void getData()
        {
            string notAvb = "Not Available";

            ManagementObjectSearcher battery = new ManagementObjectSearcher("select * from " + "Win32_Battery");
            foreach (ManagementObject data in battery.Get())

            {

                foreach (PropertyData PC in data.Properties)

                {

                    /* BATTERY NAME*/
                    try
                    {
                        batteryCaption.Text = data["Caption"].ToString();
                    }
                    catch (Exception)
                    {
                        batteryCaption.Text = notAvb;
                    }

                    /* BATTERY STATUS */
                    try
                    {
                        batteryStatus.Text = data["Status"].ToString();
                    }
                    catch (Exception)
                    {
                        batteryStatus.Text = notAvb;
                    }

                    /* BATTERY CAPACITY */
                    try
                    {
                        batteryCapacity.Text = data["DesignCapacity"].ToString() + " mA";
                    }
                    catch (Exception)
                    {
                        batteryCapacity.Text = notAvb;
                    }

                    /* BATTERY VOLTAGE */

                    try
                    {
                        float voltage = 0;

                        voltage = float.Parse(data["DesignVoltage"].ToString()) / 1000;

                        batteryVoltage.Text = voltage.ToString() + " V";
                    }
                    catch (Exception)
                    {

                        batteryVoltage.Text = notAvb;
                    }

                    /* BATTERY CHARGE */

                    try
                    {
                        batteryCharge.Value = Int32.Parse(data["EstimatedChargeRemaining"].ToString());
                        label5.Text = "Current Charge Remaining: " + batteryCharge.Value + "%";
                    }
                    catch (Exception)
                    {

                        batteryCharge.Value = 0;
                        label5.Text = "Current Charge Remaining: " + notAvb;
                    }

                    /* BATTERY ESTIMATED RUNTIME */

                    try
                    {
                        int b_runtime = 0;

                        b_runtime = Int32.Parse(data["EstimatedRunTime"].ToString());
                        if(b_runtime >= 71582788)
                        {
                            batteryRuntime.Text = "Charging...";
                        }
                        else
                        {
                            TimeSpan result = TimeSpan.FromMinutes(b_runtime);
                            batteryRuntime.Text = result.ToString();
                        }



                    }
                    catch (Exception)
                    {

                        batteryRuntime.Text = notAvb;
                    }

                    /* BATTERY FULL CHARGE CAPACITY */

                    try
                    {
                        batteryFCharge.Text = data["FullChargeCapacity"].ToString();
                    }
                    catch (Exception)
                    {

                        batteryFCharge.Text = notAvb;
                    }

                    /* BATTERY MAX RECHARGE TIME */

                    try
                    {
                        int b_maxrecharge;

                        b_maxrecharge = Int32.Parse(data["MaxRechargeTime"].ToString());
                        TimeSpan result = TimeSpan.FromMinutes(b_maxrecharge);

                        batteryMaxRecharge.Text = result.ToString();
                    }
                    catch (Exception)
                    {

                        batteryMaxRecharge.Text = notAvb;
                    }

                    /* INSTALLED DATE */

                    try
                    {
                        batteryInstalled.Text = data["InstalledDate"].ToString();
                    }
                    catch (Exception)
                    {

                        batteryInstalled.Text = notAvb;
                    }

                    /* EXPECTED LIFE */

                    try
                    {
                        batteryExpectedLife.Text = data["ExpectedLife"].ToString();
                    }
                    catch (Exception)
                    {

                        batteryExpectedLife.Text = notAvb;
                    }

                    /* EXPECTED BATTERY LIFE */

                    try
                    {
                        batteryExpectedBLife.Text = data["ExpectedBatteryLife"].ToString();
                    }
                    catch (Exception)
                    {

                        batteryExpectedBLife.Text = notAvb;
                    }
                }

                /* BATTERY TIME TO FULL CHARGE */

                try
                {
                    int b_tofull;

                    b_tofull = Int32.Parse(data["TimeToFullCharge"].ToString());
                    TimeSpan result = TimeSpan.FromMinutes(b_tofull);
         
                    batteryTimeToFull.Text = result.ToString();
                }
                catch (Exception)
                {


                    batteryTimeToFull.Text = notAvb;
                }


            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadingFrm loadingfrm = new LoadingFrm();

            loadingfrm.Show();
            getData();
            loadingfrm.Close();
        }
    }
}

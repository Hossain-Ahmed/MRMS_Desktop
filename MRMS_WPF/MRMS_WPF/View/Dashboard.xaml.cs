using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MRMS_WPF.View
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnTotalMeal_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTotalMeal.Text = (Convert.ToDecimal(TextBoxA_Meal.Text) + Convert.ToDecimal(TextBoxB_Meal.Text) + Convert.ToDecimal(TextBoxC_Meal.Text) + Convert.ToDecimal(TextBoxD_Meal.Text) + Convert.ToDecimal(TextBoxE_Meal.Text) + Convert.ToDecimal(TextBoxF_Meal.Text)).ToString();
        }

        private void BtnTotalBazar_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTotalBazar.Text = (Convert.ToDecimal(TextBoxA_Bazar.Text) + Convert.ToDecimal(TextBoxB_Bazar.Text) + Convert.ToDecimal(TextBoxC_Bazar.Text)
                                     + Convert.ToDecimal(TextBoxD_Bazar.Text) + Convert.ToDecimal(TextBoxE_Bazar.Text) + Convert.ToDecimal(TextBoxF_Bazar.Text)).ToString("0.00");
        }

        private void BtnTotalExtraBazar_Click(object sender, RoutedEventArgs e)
        {
           TextBoxTotalExtraBazar.Text = (Convert.ToDecimal(TextBoxA_ExtraBazar.Text) + Convert.ToDecimal(TextBoxB_ExtraBazar.Text) + Convert.ToDecimal(TextBoxC_ExtraBazar.Text)
                                    + Convert.ToDecimal(TextBoxD_ExtraBazar.Text) + Convert.ToDecimal(TextBoxE_ExtraBazar.Text) + Convert.ToDecimal(TextBoxF_ExtraBazar.Text)).ToString("0.00");
        }

        private void BtnTotalPay_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTotalPay.Text = (Convert.ToDecimal(TextBoxMemberA_Pay.Text) + Convert.ToDecimal(TextBoxMemberB_Pay.Text) + Convert.ToDecimal(TextBoxMemberC_Pay.Text) +
                                    Convert.ToDecimal(TextBoxMemberD_Pay.Text) + Convert.ToDecimal(TextBoxMemberE_Pay.Text) + Convert.ToDecimal(TextBoxMemberF_Pay.Text)).ToString("0.00");
        }

        private void BtnMealRate_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMealRate.Text = (Convert.ToDecimal(TextBoxTotalBazar.Text) / Convert.ToDecimal(TextBoxTotalMeal.Text)).ToString("0.00");
        }
        private void BtnExtraRate_Click(object sender, RoutedEventArgs e)
        {
             TextBoxExtraRate.Text = (Convert.ToDecimal(TextBoxTotalExtraBazar.Text) / 6 ).ToString("0.00");
        }

        private void BtnSingleTotalCost_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMemberA_Pay.Text = ( (Convert.ToDecimal(TextBoxA_Meal.Text) * Convert.ToDecimal(TextBoxMealRate.Text)) + Convert.ToDecimal(TextBoxExtraRate.Text) + Convert.ToDecimal(TextBoxUtility.Text) + Convert.ToDecimal(TextBoxNetBill.Text) + Convert.ToDecimal(TextBoxBuaBill.Text) + Convert.ToDecimal(TextBoxDirtBill.Text) + Convert.ToDecimal(TextBoxRent.Text) - Convert.ToDecimal(TextBoxA_Bazar.Text)).ToString("0.00");
            TextBoxMemberB_Pay.Text = ((Convert.ToDecimal(TextBoxB_Meal.Text) * Convert.ToDecimal(TextBoxMealRate.Text)) + Convert.ToDecimal(TextBoxExtraRate.Text) + Convert.ToDecimal(TextBoxUtility.Text) + Convert.ToDecimal(TextBoxNetBill.Text) + Convert.ToDecimal(TextBoxBuaBill.Text) + Convert.ToDecimal(TextBoxDirtBill.Text) + Convert.ToDecimal(TextBoxRent.Text) - Convert.ToDecimal(TextBoxB_Bazar.Text)).ToString("0.00");
            TextBoxMemberC_Pay.Text = ((Convert.ToDecimal(TextBoxC_Meal.Text) * Convert.ToDecimal(TextBoxMealRate.Text)) + Convert.ToDecimal(TextBoxExtraRate.Text) + Convert.ToDecimal(TextBoxUtility.Text) + Convert.ToDecimal(TextBoxNetBill.Text) + Convert.ToDecimal(TextBoxBuaBill.Text) + Convert.ToDecimal(TextBoxDirtBill.Text) + Convert.ToDecimal(TextBoxRent.Text) - Convert.ToDecimal(TextBoxC_Bazar.Text)).ToString("0.00");
            TextBoxMemberD_Pay.Text = ((Convert.ToDecimal(TextBoxD_Meal.Text) * Convert.ToDecimal(TextBoxMealRate.Text)) + Convert.ToDecimal(TextBoxExtraRate.Text) + Convert.ToDecimal(TextBoxUtility.Text) + Convert.ToDecimal(TextBoxNetBill.Text) + Convert.ToDecimal(TextBoxBuaBill.Text) + Convert.ToDecimal(TextBoxDirtBill.Text) + Convert.ToDecimal(TextBoxRent.Text) - Convert.ToDecimal(TextBoxD_Bazar.Text)).ToString("0.00");
            TextBoxMemberE_Pay.Text = ((Convert.ToDecimal(TextBoxE_Meal.Text) * Convert.ToDecimal(TextBoxMealRate.Text)) + Convert.ToDecimal(TextBoxExtraRate.Text) + Convert.ToDecimal(TextBoxUtility.Text) + Convert.ToDecimal(TextBoxNetBill.Text) + Convert.ToDecimal(TextBoxBuaBill.Text) + Convert.ToDecimal(TextBoxDirtBill.Text) + Convert.ToDecimal(TextBoxRent.Text) - Convert.ToDecimal(TextBoxE_Bazar.Text)).ToString("0.00");
            TextBoxMemberF_Pay.Text = ((Convert.ToDecimal(TextBoxF_Meal.Text) * Convert.ToDecimal(TextBoxMealRate.Text)) + Convert.ToDecimal(TextBoxExtraRate.Text) + Convert.ToDecimal(TextBoxUtility.Text) + Convert.ToDecimal(TextBoxNetBill.Text) + Convert.ToDecimal(TextBoxBuaBill.Text) + Convert.ToDecimal(TextBoxDirtBill.Text) + Convert.ToDecimal(TextBoxRent.Text) - Convert.ToDecimal(TextBoxF_Bazar.Text)).ToString("0.00");
        }
    }
}

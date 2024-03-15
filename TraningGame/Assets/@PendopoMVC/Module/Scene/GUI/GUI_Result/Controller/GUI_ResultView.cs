using Agate.MVC.Base;
using TMPro;

namespace Pendopo.TraningGame.Module.GUIResult
{
    public class GUI_ResultView : BaseView
    {
        public TextMeshProUGUI t_allProduct, t_productCount, t_productScore;
        public TextMeshProUGUI t_approve, t_approveCount, t_approveScore;
        public TextMeshProUGUI t_deny, t_denyCount, t_denyScore;
        public TextMeshProUGUI t_totalScore;
        public int multiplication;

        public void UpdateScore(int _productCount, int _productScore, int _approveCount, int _approveScore, int _denyCount,int _denyScore, int _totalScore)
        {
            t_allProduct.SetText($"Produk yang di cek hari ini");
            t_productCount.SetText($"{_productCount}");
            t_productScore.SetText($"{_productScore}");

            t_approve.SetText($"Produk yang benar lolos hari ini");
            t_approveCount.SetText($"{_approveCount}");
            t_approveScore.SetText($"{_approveScore}");

            t_deny.SetText($"Penalty (Produk yang salah cek)");
            t_denyCount.SetText($"{_denyCount}");
            t_denyScore.SetText($"{_denyScore}");

            t_totalScore.SetText($"{_totalScore}");
        }
    }
}

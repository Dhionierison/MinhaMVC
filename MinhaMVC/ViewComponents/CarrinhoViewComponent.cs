using Microsoft.AspNetCore.Mvc;

namespace MinhaMVC.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            ItensCarrinho = 3;
        }
        public async Task<IViewComponentResult> InvokeAsync() => View(ItensCarrinho);

    }
}

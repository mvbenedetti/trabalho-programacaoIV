using System;
using System.Windows;
using UMFG.Venda.Aprensetacao.Classes;
using UMFG.Venda.Aprensetacao.UserControls;
using UMFG.Venda.Aprensetacao.ViewModels;

namespace UMFG.Venda.Aprensetacao.Comandos
{
    internal sealed class ReceberPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            try
            {
                var vm = parameter as ListarProdutosViewModel;

                if (vm.Pedido.Produtos.Count == 0)
                {
                    MessageBox.Show("O pedido não contém nenhum item. Favor, informe ao menos um produto!");
                    return;
                }

                vm.Pedido = ucReceber.Exibir(vm.MainUserControl, vm.Pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

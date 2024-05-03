using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsTrabalhoIndividual.Dao
{
    public class ClienteDAO
    {
        ArrayList listaClientes = new ArrayList();


        public void inserirCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);

        }

        public ArrayList consultarClientes()
        {
            return listaClientes;
        }

        public String consultarClientesStr()
        {
            String saida = "";

            for (int i=0; i <listaClientes.Count;i++)
            {
                Cliente cliente = listaClientes[i] as Cliente;
                saida = saida + " Nome: " + cliente.nome + ";" ;
                saida = saida + " Idade: " + cliente.idade + ";";
                saida = saida + " NIF: " + cliente.nif + ";";
                saida = saida +" Numero: " + cliente.numero + ";";
                saida = saida + "\r\n";
            }


            return saida;
            
        }


    }
    }

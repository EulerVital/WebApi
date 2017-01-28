using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApiProject1.Models;

namespace WebApiProject1
{
    public partial class _default : System.Web.UI.Page
    {
        HttpClient client;
        Uri usuarioUri;

        public _default()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:57039");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getAll();
            }
        }

        private void getAll()
        {
            //chamando a api pela url
            System.Net.Http.HttpResponseMessage response = client.GetAsync("api/usuario").Result;

            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {
                //pegando o cabeçalho
                usuarioUri = response.Headers.Location;

                //Pegando os dados do Rest e armazenando na variável usuários
                var usuarios = response.Content.ReadAsAsync<List<Livro>>().Result;

                //preenchendo a lista com os dados retornados da variável
                GridView1.DataSource = usuarios;
                GridView1.DataBind();
            }

            //Se der erro na chamada, mostra o status do código de erro.
            else
                Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
        }
    }
}
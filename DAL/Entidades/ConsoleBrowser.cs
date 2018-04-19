using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entidades
{
    public class ConsoleBrowser
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public List<DetalhesLog> DetalhesLog { get; set; }
    }

    public class DetalhesLog
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }
    }


}

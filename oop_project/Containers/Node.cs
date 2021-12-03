using oop_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project.Containers
{
    public class Node
    {
        public Node(TFigure data)
        {
            this.Data = data;
        }

        public TFigure Data { get; set; }

        public Node Next { get; set; }
    }
}

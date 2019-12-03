using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AntojitoModel.Model
{
    public partial class Actions
    {

        public Actions()
        {
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public string Label { get; set; }

        public string Icon { get; set; }

    }
}

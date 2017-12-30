using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.scripts
{
    static class ColorHelper
    {
        public static Color Brown
        {
            get
            {              
                return new Color(
                    Random.Range(.35f, .44f),
                    Random.Range(.18f, .26f),
                    0, 1);
            }
        }
    }
}

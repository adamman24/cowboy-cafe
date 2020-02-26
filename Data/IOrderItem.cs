using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// interface representing single item in order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// price for item
        /// </summary>
        double Price { get; set; }

        /// <summary>
        /// special instructions for item
        /// </summary>
        List<string> SpecialInsructions { get; set; }
    }
}

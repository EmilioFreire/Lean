/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using QuantConnect.Interfaces;
using System;

namespace QuantConnect.Orders
{

    /// <summary>
    /// Contains additional properties and settings for an order submitted to Zerodha Brokerage
    /// </summary>
    public class ZerodhaOrderProperties : OrderProperties
    {

        /// <summary>
        /// Initialize a new OrderProperties for <see cref="ZerodhaOrderProperties"/>
        /// </summary>
        /// <param name="exchange">Exchange value, nse/bse etc</param>
        public ZerodhaOrderProperties(string exchange) : base(exchange)
        {
        }

        /// <summary>
        /// Returns a new instance clone of this object
        /// </summary>
        public override IOrderProperties Clone()
        {
            return (ZerodhaOrderProperties)MemberwiseClone();
        }
    }
}

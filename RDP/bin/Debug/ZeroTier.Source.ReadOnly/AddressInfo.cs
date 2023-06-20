/*
 * Copyright (c)2013-2021 ZeroTier, Inc.
 *
 * Use of this software is governed by the Business Source License included
 * in the LICENSE.TXT file in the project's root directory.
 *
 * Change Date: 2026-01-01
 *
 * On the date above, in accordance with the Business Source License, use
 * of this software will be governed by version 2.0 of the Apache License.
 */
/****/

using System.Net;

using ZeroTier;

namespace ZeroTier.Core
{
    public class AddressInfo {
        public AddressInfo(IPAddress addr, ulong net_id)
        {
            _addr = addr;
            _net_id = net_id;
        }

        public ulong _net_id;
        public IPAddress _addr;

        public IPAddress Address
        {
            get {
                return _addr;
            }
        }
        public ulong NetworkId
        {
            get {
                return _net_id;
            }
        }
    }
}

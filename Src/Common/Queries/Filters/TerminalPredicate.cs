﻿// /*
// * Copyright (c) 2016, Alachisoft. All Rights Reserved.
// *
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// *
// * http://www.apache.org/licenses/LICENSE-2.0
// *
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// */
using System.Collections.Generic;
using System.IO;
using Alachisoft.NosDB.Common.Enum;
using Alachisoft.NosDB.Common.JSON.Indexing;

namespace Alachisoft.NosDB.Common.Queries.Filters
{
    public class TerminalPredicate : Predicate<KeyValuePair<AttributeValue, long>>
    {
        private Dictionary<Statistic, double> stats;

        public TerminalPredicate()
        {
        }

        public TerminalPredicate(IList<IPredicate> chilePredicates) : base(chilePredicates)
        {
        }

        public override void Print(TextWriter output)
        {
            output.Write("TerminalPredicate:{");
            base.Print(output);
            output.Write("}");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace OliverAndEmmaRSVP
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
    }
}

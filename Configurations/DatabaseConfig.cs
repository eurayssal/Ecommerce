﻿namespace Ecommerce.Configurations;

public class DatabaseConfig : IDatabaseConfig
{
    public string DatabaseName { get; set; }
    public string ConnectionString { get; set; }
}

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DnDBagOfHolding_ApiService>("dndbagofholding-apiservice");

builder.Build().Run();

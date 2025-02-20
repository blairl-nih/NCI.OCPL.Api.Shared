﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using NCI.OCPL.Api.Common;

namespace integration_test_harness
{
  /// <summary>
  /// Defines the configuration of the test harness API.
  /// </summary>
  public class Startup : NciStartupBase
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:NCI.OCPL.Api.Common.Startup"/> class.
    /// </summary>
    /// <param name="env">Env.</param>
    public Startup(IHostingEnvironment env)
        : base(env) { }


    /*****************************
     * ConfigureServices methods *
     *****************************/

    /// <summary>
    /// Adds the configuration mappings.
    /// </summary>
    /// <param name="services">Services.</param>
    protected override void AddAdditionalConfigurationMappings(IServiceCollection services)
    {
    }

    /// <summary>
    /// Adds in the application specific services
    /// </summary>
    /// <param name="services">Services.</param>
    protected override void AddAppServices(IServiceCollection services)
    {
    }

    /*****************************
     *     Configure methods     *
     *****************************/

    /// <summary>
    /// Configure the specified app and env.
    /// </summary>
    /// <returns>The configure.</returns>
    /// <param name="app">App.</param>
    /// <param name="env">Env.</param>
    /// <param name="loggerFactory">Logger.</param>
    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    protected override void ConfigureAppSpecific(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      return;
    }
  }
}

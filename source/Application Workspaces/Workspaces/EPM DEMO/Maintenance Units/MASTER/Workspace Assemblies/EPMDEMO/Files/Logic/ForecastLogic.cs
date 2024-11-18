using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.CSharp;
using OneStream.Finance.Database;
using OneStream.Finance.Engine;
using OneStream.Shared.Common;
using OneStream.Shared.Database;
using OneStream.Shared.Engine;
using OneStream.Shared.Wcf;
using OneStream.Stage.Database;
using OneStream.Stage.Engine;
using OneStreamWorkspacesApi;
using OneStreamWorkspacesApi.V800;

namespace Workspace.__WsNamespacePrefix.__WsAssemblyName
{
	public class ForecastLogic
	{
        public void RunForecast(Ship someShip) {
            // calculate the price of the container
            decimal totalContinerPrice = 0;
            foreach(var container in someShip.Containers) {
                totalContinerPrice += container.UnitPrice * container.Size;
            }            
        }
	}
}

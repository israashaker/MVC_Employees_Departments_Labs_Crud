using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crudoperationEmpDept.Startup))]
namespace crudoperationEmpDept
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

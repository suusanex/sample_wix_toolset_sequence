using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace sample_wix_toolset_sequence_ca
{
    public class CustomActions
    {
        private static readonly string InstallFilePath =
            Environment.ExpandEnvironmentVariables(@"%ProgramFiles%\sample_wix_toolset_sequence\README.md");

        static string InstallFileTrace()
        {
            if (File.Exists(InstallFilePath))
            {
                return $"InstallFilePath Exist, Data={File.ReadAllText(InstallFilePath)}";
            }
            else
            {
                return "InstallFilePath Not Exist";
            }
        }

        [CustomAction]
        public static ActionResult InstallOrUpgradeOrUninstall(Session session)
        {
            var installTypeParams = string.Join(",",
                $"InstallTypeUpgrade={session.CustomActionData["ITU"]}",
                $"InstallTypeInstall={session.CustomActionData["ITI"]}",
                $"InstallTypeUnInstallComplete={session.CustomActionData["ITUC"]}",
                $"InstallTypeUninstallForUpgrade={session.CustomActionData["ITUU"]}"
            );
            session.Log($"Begin InstallOrUpgradeOrUninstall, installTypeParams={installTypeParams}, TempDir={session.CustomActionData["TempDir"]}, ProductVersion={session.CustomActionData["ProductVersion"]}, SourceDir={session.CustomActionData["SourceDir"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult InstallOrUpgradeOrUninstallRollback(Session session)
        {
            var installTypeParams = string.Join(",",
                $"InstallTypeUpgrade={session.CustomActionData["ITU"]}",
                $"InstallTypeInstall={session.CustomActionData["ITI"]}",
                $"InstallTypeUnInstallComplete={session.CustomActionData["ITUC"]}",
                $"InstallTypeUninstallForUpgrade={session.CustomActionData["ITUU"]}"
            );
            session.Log($"Begin InstallOrUpgradeOrUninstallRollback, installTypeParams={installTypeParams}, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

    }
}

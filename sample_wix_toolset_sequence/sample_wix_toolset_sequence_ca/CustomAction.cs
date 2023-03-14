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
        public static ActionResult InstallAndUpgradeFilesCustomAction(Session session)
        {
            session.Log($"Begin InstallAndUpgradeFilesCustomAction, TempDir={session.CustomActionData["TempDir"]}, ProductVersion={session.CustomActionData["ProductVersion"]}, SourceDir={session.CustomActionData["SourceDir"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult InstallAndUpgradeFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin InstallAndUpgradeFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult InstallOnlyFilesCustomAction(Session session)
        {
            session.Log($"Begin InstallOnlyFilesCustomAction, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult InstallOnlyFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin InstallOnlyFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UninstallFilesCustomAction(Session session)
        {
            session.Log($"Begin UninstallFilesCustomAction, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UninstallFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin UninstallFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UpgradingUninstallFilesCustomAction(Session session)
        {
            session.Log($"Begin UpgradingUninstallFilesCustomAction, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UpgradingUninstallFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin UpgradingUninstallFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UpgradeInstallFilesCustomAction(Session session)
        {
            session.Log($"Begin UpgradeInstallFilesCustomAction, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UpgradeInstallFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin UpgradeInstallFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}, InstallFile={InstallFileTrace()}");

            return ActionResult.Success;
        }
    }
}

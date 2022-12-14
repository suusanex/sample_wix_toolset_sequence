using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Collections.Generic;
using System.Text;

namespace sample_wix_toolset_sequence_ca
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult InstallAndUpgradeFilesCustomAction(Session session)
        {
            session.Log($"Begin InstallAndUpgradeFilesCustomAction, TempDir={session.CustomActionData["TempDir"]}, ProductVersion={session.CustomActionData["ProductVersion"]}, SourceDir={session.CustomActionData["SourceDir"]}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult InstallAndUpgradeFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin InstallAndUpgradeFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult InstallOnlyFilesCustomAction(Session session)
        {
            session.Log($"Begin InstallOnlyFilesCustomAction, ProductVersion={session.CustomActionData["ProductVersion"]}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult InstallOnlyFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin InstallOnlyFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UninstallFilesCustomAction(Session session)
        {
            session.Log($"Begin UninstallFilesCustomAction, ProductVersion={session.CustomActionData["ProductVersion"]}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UninstallFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin UninstallFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UpgradingUninstallFilesCustomAction(Session session)
        {
            session.Log($"Begin UpgradingUninstallFilesCustomAction, ProductVersion={session.CustomActionData["ProductVersion"]}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UpgradingUninstallFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin UpgradingUninstallFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UpgradeInstallFilesCustomAction(Session session)
        {
            session.Log($"Begin UpgradeInstallFilesCustomAction, ProductVersion={session.CustomActionData["ProductVersion"]}");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult UpgradeInstallFilesCustomActionRollback(Session session)
        {
            session.Log($"Begin UpgradeInstallFilesCustomActionRollback, ProductVersion={session.CustomActionData["ProductVersion"]}");

            return ActionResult.Success;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sandbox.Common;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Common.Components;
using Sandbox.Definitions;
using Sandbox.Engine;
using Sandbox.Game;

using Sandbox.ModAPI;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;


namespace Cyrillius // use your namespace xD
{
    [MyEntityComponentDescriptor(typeof(MyObjectBuilder_CubeBlock))] // the object typeId
    public class Regulator: MyGameLogicComponent
    {
        private MyObjectBuilder_EntityBase objectBuilder;
        private Sandbox.ModAPI.Ingame.IMyCubeBlock regulator;
        private List<Sandbox.ModAPI.Ingame.IMyTerminalBlock> reactors;
        private List<Sandbox.ModAPI.Ingame.IMyThrust> forwardReactors;
        private List<Sandbox.ModAPI.Ingame.IMyThrust> backReactors;
        private List<Sandbox.ModAPI.Ingame.IMyThrust> upReactors;
        private List<Sandbox.ModAPI.Ingame.IMyThrust> downReactors;

        public override void Init(MyObjectBuilder_EntityBase objectBuilder)
        {
            this.objectBuilder = objectBuilder;
            regulator = Entity as Sandbox.ModAPI.Ingame.IMyCubeBlock;

            Sandbox.ModAPI.Ingame.IMyGridTerminalSystem gts = Sandbox.ModAPI.MyAPIGateway.TerminalActionsHelper.GetTerminalSystemForGrid((Sandbox.ModAPI.IMyCubeGrid) regulator.CubeGrid);
            gts.GetBlocksOfType<Sandbox.ModAPI.Ingame.IMyThrust>(reactors);
            IMyThrust a = (Sandbox.ModAPI.Ingame.IMyThrust)reactors[0];
            a.

            if (regulator != null && regulator.BlockDefinition.SubtypeId == "Regulator") // check the subtypeId
            {
                Entity.NeedsUpdate |= MyEntityUpdateEnum.EACH_100TH_FRAME; // to enable UpdateBeforeSimulation100()
            }
            else
            {
            }
            
        }

        public override void UpdateBeforeSimulation100()
        {
            if (regulator == null) // make sure it's your custom block
                return;
            // go wild.
        }

        // this method is required by the extended class
        public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
        {
            return copy ? (MyObjectBuilder_EntityBase)objectBuilder.Clone() : objectBuilder;
        }
    }
}

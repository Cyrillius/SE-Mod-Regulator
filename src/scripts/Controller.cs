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


namespace Cyrillius.GameScript // use your namespace xD
{
    [MyEntityComponentDescriptor(typeof(MyObjectBuilder_CubeBlock))] // the object typeId
    public class Controller : MyGameLogicComponent
    {
        private MyObjectBuilder_EntityBase objectBuilder = null;
        private Sandbox.ModAPI.Ingame.IMyCubeBlock regulator = null;
        private List<Sandbox.ModAPI.Ingame.IMyTerminalBlock> reactors = null;
        private List<Sandbox.ModAPI.Ingame.IMyThrust> forwardReactors = null;
        private List<Sandbox.ModAPI.Ingame.IMyThrust> backReactors =  null;
        private List<Sandbox.ModAPI.Ingame.IMyThrust> upReactors = null;
        private List<Sandbox.ModAPI.Ingame.IMyThrust> downReactors = null;
        private VRageMath.Vector3D currentPosition = VRageMath.Vector3D.Zero;
        private VRageMath.Vector3D destinationPosition = VRageMath.Vector3D.Zero;

        private Cyrillius.Interface.IMyRegulator regX;
        private Cyrillius.Interface.IMyRegulator regY;
        private Cyrillius.Interface.IMyRegulator regZ;

        public override void Init(MyObjectBuilder_EntityBase objectBuilder)
        {
            this.objectBuilder = objectBuilder;
            regulator = Entity as Sandbox.ModAPI.Ingame.IMyCubeBlock;

            Sandbox.ModAPI.Ingame.IMyGridTerminalSystem gts = Sandbox.ModAPI.MyAPIGateway.TerminalActionsHelper.GetTerminalSystemForGrid((Sandbox.ModAPI.IMyCubeGrid) regulator.CubeGrid);
            gts.GetBlocksOfType<Sandbox.ModAPI.Ingame.IMyThrust>(reactors);


            if (regulator != null && regulator.BlockDefinition.SubtypeId == "Regulator") // check the subtypeId
            {
                Entity.NeedsUpdate |= MyEntityUpdateEnum.EACH_100TH_FRAME; // to enable UpdateBeforeSimulation100()
            }
            else
            {
            }
            
        }

        public VRageMath.Vector3D getCurrentPosition()
        {
            currentPosition = regulator.GetPosition();
            return currentPosition;
        }

        public VRageMath.Vector3D getDestinationPosition()
        {
            //@TODO get a position with the terminal or with GPS 
            return VRageMath.Vector3D.Zero;
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

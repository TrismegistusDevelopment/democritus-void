using UnityEngine;

namespace Inventory.ShipItems {
    [CreateAssetMenu(fileName = "New ShipRearEngine", menuName = "Game/ShipRearEngine", order = 51)]
    public class ShipRearEngine : ShipItem {
        public ShipRearEngine(ItemParams itemParams, ShipItemParams shipItemParams) : base(itemParams, shipItemParams) {
            
        }
        public override ShipItemType ItemType => ShipItemType.RearEngine;
    }
}
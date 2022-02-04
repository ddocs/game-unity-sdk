using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace MirageSDK.Examples.ContractMessages
{
	[Function("getHat", "uint256")]
	public class ItemMessage : FunctionMessage
	{
		[Parameter("uint256", "_characterId")]
		public string CharacterId { get; set; }
	}
}
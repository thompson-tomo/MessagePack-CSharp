﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

namespace MessagePack.Formatters
{
	using MsgPack = global::MessagePack;

	public sealed class ContainingClass_MyMessagePackObjectFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::ContainingClass.MyMessagePackObject>
	{
		// EnumValue
		private static global::System.ReadOnlySpan<byte> GetSpan_EnumValue() => new byte[1 + 9] { 169, 69, 110, 117, 109, 86, 97, 108, 117, 101 };

		public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::ContainingClass.MyMessagePackObject value, global::MessagePack.MessagePackSerializerOptions options)
		{
			if (value is null)
			{
				writer.WriteNil();
				return;
			}

			var formatterResolver = options.Resolver;
			writer.WriteMapHeader(1);
			writer.WriteRaw(GetSpan_EnumValue());
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::ContainingClass.MyEnum>(formatterResolver).Serialize(ref writer, value.EnumValue, options);
		}

		public global::ContainingClass.MyMessagePackObject Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			options.Security.DepthStep(ref reader);
			var formatterResolver = options.Resolver;
			var length = reader.ReadMapHeader();
			var ____result = new global::ContainingClass.MyMessagePackObject();

			for (int i = 0; i < length; i++)
			{
				var stringKey = global::MessagePack.Internal.CodeGenHelpers.ReadStringSpan(ref reader);
				switch (stringKey.Length)
				{
					default:
					FAIL:
					  reader.Skip();
					  continue;
					case 9:
					    if (!global::System.MemoryExtensions.SequenceEqual(stringKey, GetSpan_EnumValue().Slice(1))) { goto FAIL; }

					    ____result.EnumValue = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::ContainingClass.MyEnum>(formatterResolver).Deserialize(ref reader, options);
					    continue;

				}
			}

			reader.Depth--;
			return ____result;
		}
	}
}

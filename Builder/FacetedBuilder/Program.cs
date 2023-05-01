using FacetedBuilder;

var pb = new PersonBuilder();
Person person = pb
	.Works
	.At("Example Name")
	.As(".NET Developer")
	.Earning(2)
	.Lives
	.In("Somewhere")
	.At("second house on the left")
	.WithPostcode("123DR3");

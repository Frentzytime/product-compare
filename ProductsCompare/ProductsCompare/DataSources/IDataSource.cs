using System.Collections.Generic;

namespace ProductsCompare.DataSources
{
	public interface IDataSource
	{
		IList<ProductWrapper> GetAll();
	}
}

﻿using System.Collections.Generic;
using app.web.application;
using app.web.application.catalogbrowsing;
using app.web.application.stubs;

namespace app.web.core
{
  public class GetMainDepartmentsQuery : IFetchAReport<IEnumerable<Department>>
  {
    public IEnumerable<Department> fetch_using(IContainRequestDetails request)
    {
      return new StubCatalog().get_the_main_departments();
    }
  }
}
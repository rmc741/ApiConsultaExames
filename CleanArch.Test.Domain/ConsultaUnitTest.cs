using CleanArch.Domain.Entities;
using CleanArch.Domain.Validation;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Test.Domain;

public class ConsultaUnitTest
{
    [Fact]
    public void CreateConsulta_WithValidParameters_ResultObjectValidState()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy HH:mm:ss ff z}", data);
        Action action = () => new Consulta("Descrição", DateTime.Parse(formattedDate), "CRM Medico", 1, 1);
        action.Should().NotThrow<DomainValidationException>();
    }
}

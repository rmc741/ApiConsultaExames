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
        Action action = () => new Consulta("Descrição", DateTime.Now.AddDays(2), "CRM Medico", 1, 1);
        action.Should().NotThrow<DomainValidationException>();
    }
}

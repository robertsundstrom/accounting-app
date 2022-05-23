﻿using System;

using Invoices.Domain.Enums;

namespace Invoices.Application;

public record InvoiceDto(int Id, DateTime Date, Domain.Enums.InvoiceStatus Status, IEnumerable<InvoiceItemDto> Items, decimal SubTotal, decimal Vat, double? VatRate, decimal Total, decimal? Paid);

public record InvoiceItemDto(int Id, ProductType productType, string Description, decimal UnitPrice, double VatRate, double Quantity, decimal LineTotal);
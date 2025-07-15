using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers;

[Route("api/[controller]")]
[ApiController]

public class EmployeesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EmployeesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
       var allEmployees =  _context.Employees.ToList();
       return Ok(allEmployees);
    }
    
    
    [HttpGet("{id:guid}")]
    public IActionResult GetEmployeeById([FromRoute] Guid id)
    {
        var existingEmployee = _context.Employees.SingleOrDefault(x => x.Id == id);
        if (existingEmployee is null)
        {
            return NotFound();
        }

        return Ok(existingEmployee);

    }
    
    
    [HttpPost]

    public IActionResult AddEmployee([FromBody] AddEmployeeDto addEmployeeDto)
    {
        var employeeEntity = new Employee()
        {
            Name = addEmployeeDto.Name,
            Email = addEmployeeDto.Email,
            Phone = addEmployeeDto.Phone,
            Salary = addEmployeeDto.Salary

        };
        _context.Employees.Add(employeeEntity);
        _context.SaveChanges();
        return Ok(employeeEntity);

    }


    [HttpPut("{id:guid}")]

    public IActionResult UpdateEmployee([FromRoute] Guid id, [FromBody] UpdateEmployee updateEmployee)
    {
        var existingEmployee = _context.Employees.SingleOrDefault(x => x.Id == id);
        if (existingEmployee is null)
        {
            return NotFound();
        }

        existingEmployee.Name = updateEmployee.Name;
        existingEmployee.Email = updateEmployee.Email;
        existingEmployee.Phone = updateEmployee.Phone;
        existingEmployee.Salary = updateEmployee.Salary;

        _context.SaveChanges();
        return Ok(existingEmployee);

    }

    [HttpDelete("{id:guid}")]

    public IActionResult DeleteEmployee( [FromRoute] Guid id)
    {
        var existingEmployee = _context.Employees.SingleOrDefault(x => x.Id == id);
        if (existingEmployee is null)
        {
            return NotFound();

        }

        _context.Employees.Remove(existingEmployee);
        _context.SaveChanges();
        return Ok();

    }
        
}
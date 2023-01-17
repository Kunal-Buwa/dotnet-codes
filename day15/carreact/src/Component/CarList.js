import React, { Component } from "react";
import CarService from "./CarService";

class CarList extends Component
{

    constructor(props){
    super(props);

    this.state={
        cararr:[]
    }
}
componentDidMount(){
    console.log("in CarList componentDidMount");
    //getemployees method will get the data from node service and assign it to emparr and searcharr
    CarService.GetCars().then((response)=>{
        this.setState({cararr:response.data})
    })

    
}
render(){

    return(
        <div className="row">
        <table className="table table-stripped table-bordered">
          <thead>
       <tr>
           <th>Car ID</th>
           <th>Car Name</th>
           <th>Company</th>
           <th>Type</th>
       </tr>
   </thead>
   <tbody>
         {
           this.state.cararr.map((car,index)=>
           <tr key ={index}>
               <td>{car.CarID}</td>
               <td>{car.CarName}</td>
               <td>{car.Company}</td>
               <td>{car.Type}</td>
               <td></td>
           </tr>
           
           )
         }
   </tbody>
</table>
</div>
    )


        }
    }
export default CarList;
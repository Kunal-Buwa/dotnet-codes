import { useEffect, useState } from "react";

const App = () => {

    //1 create useState
    const [student, setStudents] = useState([])

    //2 call api
    useEffect(() => {
        fetch("api/student/GetStudents")
            .then(response => { return response.json() })
            .then(responseJson => {

                setStudents(responseJson)
            })
    },[])

    //3.- create div and table
    return (
        <div className="container">
            <h1>Students</h1>
            <div className="row">
                <div className="col-sm-12">
                    <table className="table table-striped">
                        <thead>
                            <tr>
                                <th>IdEmployee</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Address</th>
                                <th>Phone</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                student.map((item) => (
                                    <tr>
                                        <td>{item.id}</td>
                                        
                                        <td>{ item.name}</td>
                                        <td>{item.email}</td>
                                        <td>{item.address}</td>
                                        <td>{item.phone}</td>
                                        <td><button type="button" color="red">DELETE</button></td>
                                        <td><button type="button" color="blue">UPDATE</button></td>
                                    </tr>
                                    
                                    ))
                            }
                        </tbody>
                    </table>
                </div>
                <div>
                    
                </div>
            </div>
        </div>
    )
}

export default App;
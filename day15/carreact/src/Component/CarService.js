import axios from 'axios';

const  base_url='http://localhost:5014/api';

class CarService
{
    GetCars()
    {
        return axios.get(base_url +'Cars')
    }

}
export default new CarService();
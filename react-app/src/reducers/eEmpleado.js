import {ACTION_TYPES} from "../actions/eEmpleados";

const initialState={
    list: []
}

export const eEmpleados=(state=initialState,action) =>{
    switch(action.type){
        case ACTION_TYPES.FETCH_ALL:
        return{
            list:[...action.payload]
        }
        default:
            return state
    }
}
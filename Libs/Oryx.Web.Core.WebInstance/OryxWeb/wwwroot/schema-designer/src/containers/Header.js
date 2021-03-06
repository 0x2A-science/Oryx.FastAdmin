/**
 * @flow
 */
import { connect } from 'react-redux';
import Header from '../components/Header';
import { toggleDbModal, toggleTableModal ,updateDb } from '../actions/ActionCreators';

const mapStateToProps = (state) => ({
    dbName: state.database.name,
    dbModal: state.ui.database.showModal
});

const mapDispatchToProps = (dispatch) => ({
    toggleDbModal: (editMode = false) => {
        dispatch(toggleDbModal(editMode));
    },
    toggleTableModal: () => {
        dispatch(toggleTableModal());
    },
    updateDb:()=>{
        dispatch(updateDb())
    }
});

export default connect(mapStateToProps, mapDispatchToProps)(Header);

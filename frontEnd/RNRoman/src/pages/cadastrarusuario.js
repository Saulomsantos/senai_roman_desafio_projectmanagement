import React, { Component } from 'react';
import { Text, View, StyleSheet } from 'react-native';

class CadastrarUsuario extends Component {
    render() {
        return (
            <View style={styles.container}>
                <Text>Cadastrar Usuario</Text>
            </View>
        )
    }
}

export default CadastrarUsuario;

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});